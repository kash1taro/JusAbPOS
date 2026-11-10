using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using JusAbPOS.Domain;

namespace JusAbPOS.Data
{
    // ---------------------------------------------------------------- USERS / LOGIN
    public sealed class UserRepository
    {
        // Used to burn the same CPU time when the username does not exist (no user enumeration by timing).
        private const string DummySalt = "00000000000000000000000000000000";
        private const string DummyHash = "0000000000000000000000000000000000000000000000000000000000000000";

        /// <summary>Returns the user when username + password are valid and the account is active; otherwise null.</summary>
        public User Login(string username, string password)
        {
            int id; string name, fullName, roleName, hash, salt; bool active;

            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Login"))
            {
                Db.AddParam(cmd, "@Username", SqlDbType.NVarChar, username, 50);
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read())
                    {
                        PasswordHasher.Verify(password, DummySalt, DummyHash);
                        return null;
                    }
                    id = Convert.ToInt32(r["UserId"]);
                    name = Convert.ToString(r["Username"]);
                    fullName = Convert.ToString(r["FullName"]);
                    roleName = Convert.ToString(r["RoleName"]);
                    hash = Convert.ToString(r["PasswordHash"]);
                    salt = Convert.ToString(r["Salt"]);
                    active = Convert.ToBoolean(r["IsActive"]);
                }

                if (!PasswordHasher.Verify(password, salt, hash) || !active) return null;

                using (var touch = Db.Proc(c, "dbo.usp_User_TouchLogin"))
                {
                    Db.AddParam(touch, "@UserId", SqlDbType.Int, id);
                    touch.ExecuteNonQuery();
                }
            }

            UserRole role;
            if (!Enum.TryParse(roleName, true, out role)) role = UserRole.Cashier;   // least privilege if unknown
            return new User { Id = id, Username = name, FullName = fullName, Role = role };
        }
    }

    // ---------------------------------------------------------------- CATEGORIES
    public sealed class CategoryRepository
    {
        public List<Category> GetAll()
        {
            var list = new List<Category>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Category_List"))
            using (var r = cmd.ExecuteReader())
                while (r.Read())
                    list.Add(new Category { Id = Convert.ToInt32(r["CategoryId"]), Name = Convert.ToString(r["Name"]) });
            return list;
        }
    }

    // ---------------------------------------------------------------- PRODUCTS  (CRUD)
    public sealed class ProductRepository
    {
        /// <summary>READ (list) - dbo.usp_Product_List</summary>
        public List<Product> Search(string search, bool includeInactive)
        {
            var list = new List<Product>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Product_List"))
            {
                Db.AddParam(cmd, "@Search", SqlDbType.NVarChar, string.IsNullOrWhiteSpace(search) ? null : search, 150);
                Db.AddParam(cmd, "@IncludeInactive", SqlDbType.Bit, includeInactive);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(Map(r, false));
            }
            return list;
        }

        /// <summary>READ (one, with image) - dbo.usp_Product_Get</summary>
        public Product GetById(int id)
        {
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Product_Get"))
            {
                Db.AddParam(cmd, "@ProductId", SqlDbType.Int, id);
                using (var r = cmd.ExecuteReader())
                    return r.Read() ? Map(r, true) : null;
            }
        }

        /// <summary>CREATE - dbo.usp_Product_Insert (also writes the 'Initial stock' log row). Returns the new ProductId.</summary>
        public int Insert(Product p, int userId)
        {
            try
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_Product_Insert"))
                {
                    Db.AddParam(cmd, "@Sku", SqlDbType.NVarChar, p.Sku, 30);
                    Db.AddParam(cmd, "@Barcode", SqlDbType.NVarChar, p.Barcode, 50);
                    Db.AddParam(cmd, "@Name", SqlDbType.NVarChar, p.Name, 150);
                    Db.AddParam(cmd, "@CategoryId", SqlDbType.Int, p.CategoryId);
                    Db.AddParam(cmd, "@Price", SqlDbType.Decimal, p.Price);
                    Db.AddParam(cmd, "@Cost", SqlDbType.Decimal, p.Cost);
                    Db.AddParam(cmd, "@StockQty", SqlDbType.Int, p.StockQty);
                    Db.AddParam(cmd, "@ReorderLevel", SqlDbType.Int, p.ReorderLevel);
                    Db.AddParam(cmd, "@Image", SqlDbType.VarBinary, p.Image, -1);
                    Db.AddParam(cmd, "@UserId", SqlDbType.Int, userId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                if (!Db.IsBusinessError(ex)) throw;
                throw Db.Translate(ex);
            }
        }

        /// <summary>UPDATE - dbo.usp_Product_Update. Stock is changed only through AdjustStock so it is always logged.</summary>
        public void Update(Product p, bool changeImage)
        {
            try
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_Product_Update"))
                {
                    Db.AddParam(cmd, "@ProductId", SqlDbType.Int, p.Id);
                    Db.AddParam(cmd, "@Sku", SqlDbType.NVarChar, p.Sku, 30);
                    Db.AddParam(cmd, "@Barcode", SqlDbType.NVarChar, p.Barcode, 50);
                    Db.AddParam(cmd, "@Name", SqlDbType.NVarChar, p.Name, 150);
                    Db.AddParam(cmd, "@CategoryId", SqlDbType.Int, p.CategoryId);
                    Db.AddParam(cmd, "@Price", SqlDbType.Decimal, p.Price);
                    Db.AddParam(cmd, "@Cost", SqlDbType.Decimal, p.Cost);
                    Db.AddParam(cmd, "@ReorderLevel", SqlDbType.Int, p.ReorderLevel);
                    Db.AddParam(cmd, "@IsActive", SqlDbType.Bit, p.IsActive);
                    Db.AddParam(cmd, "@Image", SqlDbType.VarBinary, p.Image, -1);
                    Db.AddParam(cmd, "@ChangeImage", SqlDbType.Bit, changeImage);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                if (!Db.IsBusinessError(ex)) throw;
                throw Db.Translate(ex);
            }
        }

        /// <summary>DELETE - dbo.usp_Product_Delete is a SOFT delete (IsActive = 0) so sales history stays intact.</summary>
        public void Delete(int id)
        {
            try
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_Product_Delete"))
                {
                    Db.AddParam(cmd, "@ProductId", SqlDbType.Int, id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                if (!Db.IsBusinessError(ex)) throw;
                throw Db.Translate(ex);
            }
        }

        /// <summary>Stock adjustment (+/-) with an InventoryLog row - dbo.usp_Inventory_Adjust. Returns the new stock.</summary>
        public int AdjustStock(int productId, int change, string reason, int userId)
        {
            try
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_Inventory_Adjust"))
                {
                    Db.AddParam(cmd, "@ProductId", SqlDbType.Int, productId);
                    Db.AddParam(cmd, "@ChangeQty", SqlDbType.Int, change);
                    Db.AddParam(cmd, "@Reason", SqlDbType.NVarChar, reason, 200);
                    Db.AddParam(cmd, "@UserId", SqlDbType.Int, userId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                if (!Db.IsBusinessError(ex)) throw;
                throw Db.Translate(ex);
            }
        }

        private static Product Map(SqlDataReader r, bool withImage)
        {
            var p = new Product
            {
                Id = Convert.ToInt32(r["ProductId"]),
                Sku = Convert.ToString(r["Sku"]),
                Barcode = r["Barcode"] == DBNull.Value ? null : Convert.ToString(r["Barcode"]),
                Name = Convert.ToString(r["Name"]),
                CategoryId = Convert.ToInt32(r["CategoryId"]),
                CategoryName = Convert.ToString(r["CategoryName"]),
                Price = Convert.ToDecimal(r["Price"]),
                Cost = Convert.ToDecimal(r["Cost"]),
                StockQty = Convert.ToInt32(r["StockQty"]),
                ReorderLevel = Convert.ToInt32(r["ReorderLevel"]),
                IsActive = Convert.ToBoolean(r["IsActive"])
            };
            if (withImage && r["Image"] != DBNull.Value) p.Image = (byte[])r["Image"];
            return p;
        }
    }

    // ---------------------------------------------------------------- DASHBOARD
    public sealed class DashboardRepository
    {
        /// <summary>dbo.usp_Report_Dashboard</summary>
        public DashboardStats GetStats()
        {
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Report_Dashboard"))
            using (var r = cmd.ExecuteReader())
            {
                if (!r.Read()) return new DashboardStats();
                return new DashboardStats
                {
                    TodaySales = Convert.ToDecimal(r["TodaySales"]),
                    TodayOrders = Convert.ToInt32(r["TodayOrders"]),
                    LowStockCount = Convert.ToInt32(r["LowStockCount"]),
                    ActiveProducts = Convert.ToInt32(r["ActiveProducts"])
                };
            }
        }

        /// <summary>dbo.usp_Report_LowStock</summary>
        public List<LowStockItem> GetLowStock()
        {
            var list = new List<LowStockItem>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Report_LowStock"))
            using (var r = cmd.ExecuteReader())
                while (r.Read())
                    list.Add(new LowStockItem
                    {
                        ProductId = Convert.ToInt32(r["ProductId"]),
                        Sku = Convert.ToString(r["Sku"]),
                        Name = Convert.ToString(r["Name"]),
                        StockQty = Convert.ToInt32(r["StockQty"]),
                        ReorderLevel = Convert.ToInt32(r["ReorderLevel"])
                    });
            return list;
        }
    }
}

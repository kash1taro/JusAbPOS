using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;
using JusAbPOS.Domain;

namespace JusAbPOS.Data
{
    public sealed class CustomerRepository
    {
        /// <summary>dbo.usp_Customer_List</summary>
        public List<Customer> GetAll()
        {
            var list = new List<Customer>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Customer_List"))
            using (var r = cmd.ExecuteReader())
                while (r.Read())
                    list.Add(new Customer
                    {
                        Id = Convert.ToInt32(r["CustomerId"]),
                        FullName = Convert.ToString(r["FullName"]),
                        Phone = r["Phone"] == DBNull.Value ? null : Convert.ToString(r["Phone"])
                    });
            return list;
        }
    }

    public static class CustomerWrites
    {
        /// <summary>dbo.usp_Customer_Create - returns the new CustomerId.</summary>
        public static int Create(string fullName, string phone)
        {
            try
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_Customer_Create"))
                {
                    Db.AddParam(cmd, "@FullName", SqlDbType.NVarChar, fullName, 100);
                    Db.AddParam(cmd, "@Phone", SqlDbType.NVarChar, phone, 30);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                if (!Db.IsBusinessError(ex)) throw;
                throw Db.Translate(ex);
            }
        }
    }

    public sealed class OrderRepository
    {
        /// <summary>
        /// dbo.usp_Order_Create - one transaction: validates stock, prices every line from Products, writes the order,
        /// the order lines, reduces stock and logs it. Returns the new OrderId.
        /// </summary>
        public int Create(int userId, int? customerId, string paymentMethod, decimal discount, decimal taxRatePercent,
                          decimal amountPaid, IEnumerable<CartLine> lines)
        {
            // The cart travels as XML: <Items><Item ProductId="1" Quantity="2"/></Items>  (ids and quantities only)
            var xml = new XElement("Items",
                lines.Select(l => new XElement("Item",
                    new XAttribute("ProductId", l.ProductId),
                    new XAttribute("Quantity", l.Quantity)))).ToString(SaveOptions.DisableFormatting);
            try
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_Order_Create"))
                {
                    Db.AddParam(cmd, "@UserId", SqlDbType.Int, userId);
                    Db.AddParam(cmd, "@CustomerId", SqlDbType.Int, customerId);
                    Db.AddParam(cmd, "@PaymentMethod", SqlDbType.NVarChar, paymentMethod, 20);
                    Db.AddParam(cmd, "@DiscountAmount", SqlDbType.Decimal, discount);
                    Db.AddParam(cmd, "@TaxRate", SqlDbType.Decimal, taxRatePercent);
                    Db.AddParam(cmd, "@AmountPaid", SqlDbType.Decimal, amountPaid);
                    Db.AddParam(cmd, "@ItemsXml", SqlDbType.Xml, xml);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                if (!Db.IsBusinessError(ex)) throw;
                throw Db.Translate(ex);
            }
        }

        /// <summary>dbo.usp_Order_Get - reads the COMMITTED order, so the receipt always shows what was really saved.</summary>
        public ReceiptData GetReceipt(int orderId)
        {
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Order_Get"))
            {
                Db.AddParam(cmd, "@OrderId", SqlDbType.Int, orderId);
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    var receipt = new ReceiptData
                    {
                        OrderNumber = Convert.ToString(r["OrderNumber"]),
                        Date = Convert.ToDateTime(r["OrderDate"]),
                        CashierName = Convert.ToString(r["CashierName"]),
                        Subtotal = Convert.ToDecimal(r["Subtotal"]),
                        Tax = Convert.ToDecimal(r["TaxAmount"]),
                        Discount = Convert.ToDecimal(r["DiscountAmount"]),
                        Total = Convert.ToDecimal(r["Total"]),
                        PaymentMethod = Convert.ToString(r["PaymentMethod"]).ToUpperInvariant(),
                        AmountTendered = Convert.ToDecimal(r["AmountPaid"]),
                        Change = Convert.ToDecimal(r["ChangeDue"])
                    };
                    if (r.NextResult())
                        while (r.Read())
                            receipt.Lines.Add(new ReceiptLine
                            {
                                ProductName = Convert.ToString(r["ProductName"]),
                                Quantity = Convert.ToInt32(r["Quantity"]),
                                UnitPrice = Convert.ToDecimal(r["UnitPrice"]),
                                Amount = Convert.ToDecimal(r["LineTotal"])
                            });
                    return receipt;
                }
            }
        }
    }

    public sealed class ReportRepository
    {
        public List<DailySalesRow> DailySales(DateTime from, DateTime to)
        {
            var list = new List<DailySalesRow>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Report_DailySales"))
            {
                Db.AddParam(cmd, "@From", SqlDbType.DateTime, from);
                Db.AddParam(cmd, "@To", SqlDbType.DateTime, to);
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new DailySalesRow
                        {
                            SaleDate = Convert.ToDateTime(r["SaleDate"]),
                            OrderCount = Convert.ToInt32(r["OrderCount"]),
                            Revenue = Convert.ToDecimal(r["Revenue"])
                        });
            }
            return list;
        }

        public List<TopProductRow> TopProducts(DateTime from, DateTime to, int top)
        {
            var list = new List<TopProductRow>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Report_TopProducts"))
            {
                Db.AddParam(cmd, "@From", SqlDbType.DateTime, from);
                Db.AddParam(cmd, "@To", SqlDbType.DateTime, to);
                Db.AddParam(cmd, "@Top", SqlDbType.Int, top);
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new TopProductRow
                        {
                            ProductName = Convert.ToString(r["ProductName"]),
                            QtySold = Convert.ToInt32(r["QtySold"]),
                            Revenue = Convert.ToDecimal(r["Revenue"])
                        });
            }
            return list;
        }

        public List<CategorySalesRow> SalesByCategory(DateTime from, DateTime to)
        {
            var list = new List<CategorySalesRow>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Report_SalesByCategory"))
            {
                Db.AddParam(cmd, "@From", SqlDbType.DateTime, from);
                Db.AddParam(cmd, "@To", SqlDbType.DateTime, to);
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new CategorySalesRow
                        {
                            CategoryName = Convert.ToString(r["CategoryName"]),
                            Revenue = Convert.ToDecimal(r["Revenue"])
                        });
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using JusAbPOS.Data;
using JusAbPOS.Domain;

namespace JusAbPOS.Services
{
    // ------------------------------------------------------------------ AUTHENTICATION
    public sealed class AuthService
    {
        private readonly UserRepository repo = new UserRepository();

        /// <summary>Returns the signed-in user, or null for ANY bad credential (the caller shows one generic message,
        /// so the screen never reveals whether a username exists).</summary>
        public User Login(string username, string password)
        {
            username = (username ?? "").Trim();
            if (username.Length == 0 || string.IsNullOrEmpty(password))
                throw new ArgumentException("Enter your username and password.");
            if (username.Length > 50 || password.Length > 100) return null;
            return repo.Login(username, password);
        }
    }

    // ------------------------------------------------------------------ INVENTORY (CRUD)
    public sealed class InventoryService
    {
        public const int MaxImageBytes = 2 * 1024 * 1024;   // 2 MB
        private static readonly Regex SkuPattern = new Regex(@"^[A-Za-z0-9._\-]+$", RegexOptions.Compiled);

        private readonly User actor;
        private readonly ProductRepository products = new ProductRepository();
        private readonly CategoryRepository categories = new CategoryRepository();

        public InventoryService(User actor)
        {
            if (actor == null) throw new ArgumentNullException("actor");
            this.actor = actor;
        }

        // Authorization is enforced HERE, not only by hiding menu items (tutorial section 12).
        private void RequireAccess()
        {
            if (!actor.CanManageInventory)
                throw new UnauthorizedAccessException("Your role does not allow inventory management.");
        }

        public List<Product> Search(string text, bool includeInactive)
        {
            RequireAccess();
            return products.Search(text, includeInactive);
        }

        public Product GetById(int id)
        {
            RequireAccess();
            return products.GetById(id);
        }

        public List<Category> GetCategories()
        {
            RequireAccess();
            return categories.GetAll();
        }

        public int Create(Product p)
        {
            RequireAccess();
            Normalize(p);
            Validate(p, true);
            return products.Insert(p, actor.Id);
        }

        public void Update(Product p, bool changeImage)
        {
            RequireAccess();
            if (p.Id <= 0) throw new ArgumentException("Select a product to update.");
            Normalize(p);
            Validate(p, false);
            products.Update(p, changeImage);
        }

        /// <summary>Soft delete: the product is deactivated, not removed, so past orders keep their history.</summary>
        public void Delete(int id)
        {
            RequireAccess();
            if (id <= 0) throw new ArgumentException("Select a product to delete.");
            products.Delete(id);
        }

        public int AdjustStock(int productId, int change, string reason)
        {
            RequireAccess();
            reason = (reason ?? "").Trim();
            if (productId <= 0) throw new ArgumentException("Select a product.");
            if (change == 0) throw new ArgumentException("The adjustment cannot be zero.");
            if (reason.Length == 0) throw new ArgumentException("A reason is required for a stock adjustment.");
            if (reason.Length > 200) throw new ArgumentException("The reason must be 200 characters or fewer.");
            return products.AdjustStock(productId, change, reason, actor.Id);
        }

        private static void Normalize(Product p)
        {
            p.Sku = (p.Sku ?? "").Trim();
            p.Name = (p.Name ?? "").Trim();
            var barcode = (p.Barcode ?? "").Trim();
            p.Barcode = barcode.Length == 0 ? null : barcode;   // '' would collide with the unique barcode index
        }

        private static void Validate(Product p, bool isNew)
        {
            if (p.Sku.Length == 0) throw new ArgumentException("SKU is required.");
            if (p.Sku.Length > 30) throw new ArgumentException("SKU must be 30 characters or fewer.");
            if (!SkuPattern.IsMatch(p.Sku)) throw new ArgumentException("SKU may contain only letters, digits, '-', '_' and '.'.");
            if (p.Barcode != null && p.Barcode.Length > 50) throw new ArgumentException("Barcode must be 50 characters or fewer.");
            if (p.Name.Length == 0) throw new ArgumentException("Product name is required.");
            if (p.Name.Length > 150) throw new ArgumentException("Product name must be 150 characters or fewer.");
            if (p.CategoryId <= 0) throw new ArgumentException("Choose a category.");
            if (p.Price < 0) throw new ArgumentException("Selling price cannot be negative.");
            if (p.Cost < 0) throw new ArgumentException("Cost cannot be negative.");
            if (p.ReorderLevel < 0) throw new ArgumentException("Reorder level must be zero or greater.");
            if (isNew && p.StockQty < 0) throw new ArgumentException("Stock cannot be negative.");
            if (p.Image != null && p.Image.Length > MaxImageBytes) throw new ArgumentException("The image must be 2 MB or smaller.");
        }
    }

    // ------------------------------------------------------------------ DASHBOARD
    public sealed class DashboardService
    {
        private readonly DashboardRepository repo = new DashboardRepository();
        public DashboardStats GetStats() { return repo.GetStats(); }
        public List<LowStockItem> GetLowStock() { return repo.GetLowStock(); }
    }
}

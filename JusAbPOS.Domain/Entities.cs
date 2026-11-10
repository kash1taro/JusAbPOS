using System;
using System.Collections.Generic;

namespace JusAbPOS.Domain
{
    /// <summary>Values match Roles.RoleId in the abejar database (1 = Admin, 2 = Manager, 3 = Cashier).</summary>
    public enum UserRole { Admin = 1, Manager = 2, Cashier = 3 }

    public sealed class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public UserRole Role { get; set; }

        /// <summary>Admins and managers may view sales analytics.</summary>
        public bool CanViewReports
        {
            get { return Role == UserRole.Admin || Role == UserRole.Manager; }
        }

        /// <summary>Admins and managers may open and change the inventory.</summary>
        public bool CanManageInventory
        {
            get { return Role == UserRole.Admin || Role == UserRole.Manager; }
        }
    }

    public sealed class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() { return Name; }
    }

    public sealed class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }          // selling price
        public decimal Cost { get; set; }
        public int StockQty { get; set; }
        public int ReorderLevel { get; set; }
        public byte[] Image { get; set; }            // only filled by GetById
        public bool IsActive { get; set; }

        public bool IsLowStock { get { return StockQty <= ReorderLevel; } }
    }

    public sealed class LowStockItem
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public int StockQty { get; set; }
        public int ReorderLevel { get; set; }
    }

    public sealed class DashboardStats
    {
        public decimal TodaySales { get; set; }
        public int TodayOrders { get; set; }
        public int LowStockCount { get; set; }
        public int ActiveProducts { get; set; }
    }

    // ---------------------------------------------------------------- SALES / RECEIPTS
    public sealed class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
    }

    /// <summary>One line in the checkout cart. Prices shown here are a preview - the database re-prices every order.</summary>
    public sealed class CartLine
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int Available { get; set; }          // stock on hand when the line was added
        public decimal LineTotal { get { return Quantity * UnitPrice; } }
    }

    public sealed class OrderTotals
    {
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }

    public sealed class ReceiptLine
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
    }

    public sealed class ReceiptData
    {
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessPhone { get; set; }
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public string CashierName { get; set; }
        public List<ReceiptLine> Lines { get; } = new List<ReceiptLine>();
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountTendered { get; set; }
        public decimal Change { get; set; }
    }

    // ---------------------------------------------------------------- REPORT ROWS
    public sealed class DailySalesRow
    {
        public DateTime SaleDate { get; set; }
        public int OrderCount { get; set; }
        public decimal Revenue { get; set; }
    }

    public sealed class TopProductRow
    {
        public string ProductName { get; set; }
        public int QtySold { get; set; }
        public decimal Revenue { get; set; }
    }

    public sealed class CategorySalesRow
    {
        public string CategoryName { get; set; }
        public decimal Revenue { get; set; }
    }

    // ---------------------------------------------------------------- USER ADMINISTRATION
    public sealed class UserAccount
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastLoginAt { get; set; }
    }

    public sealed class RoleItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

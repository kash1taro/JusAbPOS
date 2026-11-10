using System;
using System.Collections.Generic;
using System.Linq;
using JusAbPOS.Data;
using JusAbPOS.Domain;

namespace JusAbPOS.Services
{
    /// <summary>Printing contract (tutorial B.3). The WinForms project supplies the implementation.</summary>
    public interface IReceiptPrinter
    {
        void Preview(ReceiptData receipt);
        void Print(ReceiptData receipt);
    }

    // ------------------------------------------------------------------ CHECKOUT  (all roles may sell)
    public sealed class SalesService
    {
        public static readonly string[] PaymentMethods = { "Cash", "Card", "Mobile" };

        private readonly User actor;
        private readonly ProductRepository products = new ProductRepository();
        private readonly CustomerRepository customers = new CustomerRepository();
        private readonly OrderRepository orders = new OrderRepository();

        public SalesService(User actor)
        {
            if (actor == null) throw new ArgumentNullException("actor");
            this.actor = actor;
        }

        /// <summary>Finds ONE active product by exact SKU or barcode (what a barcode scanner types). Null if none.</summary>
        public Product FindProduct(string code)
        {
            code = (code ?? "").Trim();
            if (code.Length == 0) return null;
            return products.Search(code, false).FirstOrDefault(p =>
                string.Equals(p.Sku, code, StringComparison.OrdinalIgnoreCase) ||
                (p.Barcode != null && string.Equals(p.Barcode, code, StringComparison.OrdinalIgnoreCase)));
        }

        /// <summary>Active products for the point-of-sale list (any role may sell, so no inventory permission is needed).</summary>
        public List<Product> SearchProducts(string text) { return products.Search(text, false); }

        public List<Customer> GetCustomers() { return customers.GetAll(); }

        public int AddCustomer(string fullName, string phone)
        {
            fullName = (fullName ?? "").Trim();
            phone = (phone ?? "").Trim();
            if (fullName.Length == 0) throw new ArgumentException("Customer name is required.");
            if (fullName.Length > 100) throw new ArgumentException("Customer name must be 100 characters or fewer.");
            if (phone.Length > 30) throw new ArgumentException("Phone must be 30 characters or fewer.");
            return CustomerWrites.Create(fullName, phone.Length == 0 ? null : phone);
        }

        /// <summary>Same arithmetic as dbo.usp_Order_Create: tax = ROUND((subtotal - discount) * rate / 100, 2).</summary>
        public static OrderTotals Calculate(IEnumerable<CartLine> cart, decimal discount, decimal taxRatePercent)
        {
            var subtotal = cart.Sum(l => l.LineTotal);
            var tax = Math.Round((subtotal - discount) * taxRatePercent / 100m, 2, MidpointRounding.AwayFromZero);
            return new OrderTotals { Subtotal = subtotal, Discount = discount, Tax = tax, Total = subtotal - discount + tax };
        }

        /// <summary>Saves the sale. Returns the OrderId. Stock, prices and totals are re-checked inside the database.</summary>
        public int Checkout(IList<CartLine> cart, int? customerId, string paymentMethod, decimal discount,
                            decimal taxRatePercent, decimal amountPaid)
        {
            if (cart == null || cart.Count == 0) throw new ArgumentException("The cart is empty.");
            if (cart.Any(l => l.Quantity <= 0)) throw new ArgumentException("Every quantity must be at least 1.");
            if (!PaymentMethods.Contains(paymentMethod)) throw new ArgumentException("Choose a payment method.");
            if (taxRatePercent < 0 || taxRatePercent > 100) throw new ArgumentException("The tax rate must be between 0 and 100.");

            var t = Calculate(cart, 0, 0);
            if (discount < 0 || discount > t.Subtotal) throw new ArgumentException("The discount must be between 0 and the subtotal.");
            var totals = Calculate(cart, discount, taxRatePercent);
            if (amountPaid < totals.Total) throw new ArgumentException("The amount paid is less than the total.");

            return orders.Create(actor.Id, customerId, paymentMethod, discount, taxRatePercent, amountPaid, cart);
        }

        public ReceiptData GetReceipt(int orderId)
        {
            var receipt = orders.GetReceipt(orderId);
            if (receipt == null) throw new InvalidOperationException("The order could not be found.");
            return receipt;
        }
    }

    // ------------------------------------------------------------------ ANALYTICS  (Admin / Manager)
    public sealed class ReportingService
    {
        private readonly User actor;
        private readonly ReportRepository repo = new ReportRepository();

        public ReportingService(User actor)
        {
            if (actor == null) throw new ArgumentNullException("actor");
            this.actor = actor;
        }

        private void Check(DateTime from, DateTime to)
        {
            if (!actor.CanViewReports) throw new UnauthorizedAccessException("Your role does not allow viewing sales analytics.");
            if (from.Date > to.Date) throw new ArgumentException("The 'From' date must not be after the 'To' date.");
        }

        public List<DailySalesRow> DailySales(DateTime from, DateTime to) { Check(from, to); return repo.DailySales(from.Date, to.Date); }
        public List<TopProductRow> TopProducts(DateTime from, DateTime to, int top) { Check(from, to); return repo.TopProducts(from.Date, to.Date, top); }
        public List<CategorySalesRow> SalesByCategory(DateTime from, DateTime to) { Check(from, to); return repo.SalesByCategory(from.Date, to.Date); }
    }
}

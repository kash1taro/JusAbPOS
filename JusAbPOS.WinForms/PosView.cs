using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    /// <summary>Point of Sale: find / scan products, build the cart, pay, print the receipt. Layout: PosView.Designer.cs</summary>
    public partial class PosView : UserControl, IRefreshable
    {
        private readonly decimal taxRate = AppSettings.TaxRatePercent;
        private readonly BindingList<CartLine> cart = new BindingList<CartLine>();
        private SalesService sales;

        public PosView()
        {
            InitializeComponent();
        }

        public PosView(User user) : this()
        {
            sales = new SalesService(user);
            lblTaxCaption.Text = "Tax (" + taxRate.ToString("0.##") + "%)";
            gridCart.DataSource = cart;
            cart.ListChanged += (s, e) => UpdateTotals();
        }

        private void PosView_Load(object sender, EventArgs e)
        {
            if (sales == null) return;             // design-time
            LoadProducts();
            LoadCustomers(null);
            UpdateTotals();
            BeginInvoke(new Action(() => txtScan.Focus()));
        }

        public void RefreshData()
        {
            if (sales == null) return;
            LoadProducts();
            var id = SelectedCustomerId();
            LoadCustomers(id);
        }

        // ------------------------------------------------------------ product list
        private void LoadProducts()
        {
            try { gridProducts.DataSource = new BindingList<Product>(sales.SearchProducts(txtFind.Text.Trim())); }
            catch (Exception ex) { UiHelper.ShowError(ex, "Products"); }
        }

        private void LoadCustomers(int? select)
        {
            var list = new List<Customer> { new Customer { Id = 0, FullName = "Walk-in customer" } };
            try { list.AddRange(sales.GetCustomers()); }
            catch (Exception ex) { AppLog.Write(ex); }          // selling still works as a walk-in
            cboCustomer.DisplayMember = "FullName";
            cboCustomer.ValueMember = "Id";
            cboCustomer.DataSource = list;
            cboCustomer.SelectedValue = select ?? 0;
        }

        private int? SelectedCustomerId()
        {
            var id = cboCustomer.SelectedValue is int ? (int)cboCustomer.SelectedValue : 0;
            return id > 0 ? (int?)id : null;
        }

        private void gridProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gridProducts.Rows)
            {
                var p = row.DataBoundItem as Product;
                if (p != null && p.StockQty <= 0) row.DefaultCellStyle.ForeColor = Color.Gray;
                else if (p != null && p.IsLowStock) row.DefaultCellStyle.ForeColor = Color.FromArgb(190, 90, 0);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) { LoadProducts(); }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            LoadProducts();
        }

        // ------------------------------------------------------------ adding to the cart
        private void txtScan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;                 // scanners send Enter after the code
            var code = txtScan.Text.Trim();
            if (code.Length == 0) return;
            try
            {
                var product = sales.FindProduct(code);
                if (product == null)
                {
                    UiHelper.Warn("No active product with SKU or barcode '" + code + "'.", "Point of Sale");
                    txtScan.SelectAll();
                    return;
                }
                if (AddToCart(product, (int)numQty.Value)) { txtScan.Clear(); numQty.Value = 1; }
                else txtScan.SelectAll();
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Point of Sale"); }
            txtScan.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSelectedProduct((int)numQty.Value);
            numQty.Value = 1;
        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) AddSelectedProduct(1);
        }

        private void gridProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.Handled = true;
            AddSelectedProduct(1);
        }

        private void AddSelectedProduct(int qty)
        {
            var p = gridProducts.CurrentRow == null ? null : gridProducts.CurrentRow.DataBoundItem as Product;
            if (p == null) { UiHelper.Warn("Select a product in the list first.", "Point of Sale"); return; }
            AddToCart(p, qty);
        }

        /// <summary>Adds qty of a product (merging with an existing line). Returns false if stock does not allow it.</summary>
        private bool AddToCart(Product product, int qty)
        {
            var existing = cart.FirstOrDefault(l => l.ProductId == product.Id);
            var wanted = qty + (existing == null ? 0 : existing.Quantity);
            if (product.StockQty <= 0)
            {
                UiHelper.Warn("'" + product.Name + "' is out of stock.", "Point of Sale");
                return false;
            }
            if (wanted > product.StockQty)
            {
                UiHelper.Warn("Only " + product.StockQty + " of '" + product.Name + "' in stock.", "Point of Sale");
                return false;
            }

            if (existing != null)
            {
                existing.Quantity = wanted;
                existing.Available = product.StockQty;
                existing.UnitPrice = product.Price;
                cart.ResetItem(cart.IndexOf(existing));
            }
            else
            {
                cart.Add(new CartLine
                {
                    ProductId = product.Id, Sku = product.Sku, ProductName = product.Name,
                    Quantity = qty, UnitPrice = product.Price, Available = product.StockQty
                });
            }
            return true;
        }

        // ------------------------------------------------------------ editing the cart
        private CartLine SelectedLine()
        {
            return gridCart.CurrentRow == null ? null : gridCart.CurrentRow.DataBoundItem as CartLine;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            var line = SelectedLine();
            if (line == null) return;
            if (line.Quantity + 1 > line.Available)
            {
                UiHelper.Warn("Only " + line.Available + " of '" + line.ProductName + "' in stock.", "Point of Sale");
                return;
            }
            line.Quantity++;
            cart.ResetItem(cart.IndexOf(line));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var line = SelectedLine();
            if (line == null || line.Quantity <= 1) return;
            line.Quantity--;
            cart.ResetItem(cart.IndexOf(line));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var line = SelectedLine();
            if (line != null) cart.Remove(line);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cart.Count > 0 && UiHelper.Confirm("Remove every item from the cart?", "Clear cart")) cart.Clear();
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e) { UpdateTotals(); }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var form = new CustomerForm(sales))
                if (form.ShowDialog(FindForm()) == DialogResult.OK) LoadCustomers(form.CreatedCustomerId);
        }

        // ------------------------------------------------------------ totals
        private void UpdateTotals()
        {
            var subtotal = cart.Sum(l => l.LineTotal);
            var discount = Math.Min(UiHelper.LiveValue(numDiscount), subtotal);   // display only; the service rejects a bad discount
            var totals = SalesService.Calculate(cart, discount, taxRate);
            lblSubtotal.Text = totals.Subtotal.ToString("C2");
            lblTax.Text = totals.Tax.ToString("C2");
            lblTotal.Text = totals.Total.ToString("C2");
            btnCheckout.Enabled = cart.Count > 0;
        }

        // ------------------------------------------------------------ checkout (button or F9)
        private void btnCheckout_Click(object sender, EventArgs e) { Checkout(); }

        public void Checkout()
        {
            if (sales == null || cart.Count == 0) return;

            var discount = numDiscount.Value;
            var totals = SalesService.Calculate(cart, discount, taxRate);
            if (discount > totals.Subtotal)
            {
                UiHelper.Warn("The discount cannot be more than the subtotal.", "Checkout");
                return;
            }

            string method;
            decimal paid;
            using (var payment = new PaymentForm(totals.Total))
            {
                if (payment.ShowDialog(FindForm()) != DialogResult.OK) return;
                method = payment.PaymentMethod;
                paid = payment.AmountPaid;
            }

            int orderId;
            try
            {
                orderId = sales.Checkout(cart.ToList(), SelectedCustomerId(), method, discount, taxRate, paid);
            }
            catch (Exception ex)
            {
                UiHelper.ShowError(ex, "Checkout");
                LoadProducts();                       // show the real stock levels
                return;
            }

            // The sale is saved. Everything below only concerns the receipt and must never undo or repeat it.
            cart.Clear();
            numDiscount.Value = 0;
            LoadProducts();

            try
            {
                var receipt = sales.GetReceipt(orderId);
                AppSettings.ApplyBusinessInfo(receipt);
                var answer = MessageBox.Show(
                    "Order " + receipt.OrderNumber + " saved.\n\nTotal: " + receipt.Total.ToString("C2") +
                    "\nChange: " + receipt.Change.ToString("C2") + "\n\nPreview / print the receipt now?",
                    "Sale complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer == DialogResult.Yes) new ReceiptPrinter().Preview(receipt);   // the preview window has a Print button
            }
            catch (Exception ex)
            {
                AppLog.Write(ex);
                UiHelper.Warn("The sale was saved (order id " + orderId + "), but the receipt could not be shown. " +
                              "Check that a printer is installed.", "Sale complete");
            }
            txtScan.Focus();
        }
    }
}

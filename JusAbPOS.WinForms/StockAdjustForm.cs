using System;
using System.Drawing;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    /// <summary>Add (+) or remove (-) stock with a reason; every change is written to InventoryLog by the database.</summary>
    public partial class StockAdjustForm : Form
    {
        private readonly InventoryService service;
        private readonly Product product;

        public StockAdjustForm()
        {
            InitializeComponent();
        }

        public StockAdjustForm(User user, Product selected) : this()
        {
            service = new InventoryService(user);
            product = selected;
            lblProduct.Text = product.Sku + " - " + product.Name;
            lblCurrent.Text = product.StockQty.ToString();
            ShowResult();
        }

        private void numChange_ValueChanged(object sender, EventArgs e)
        {
            ShowResult();
        }

        private void ShowResult()
        {
            if (product == null) return;
            var result = product.StockQty + (int)UiHelper.LiveValue(numChange);
            lblNew.Text = result.ToString();
            lblNew.ForeColor = result < 0 ? Color.FromArgb(206, 38, 38)
                             : result <= product.ReorderLevel ? Color.DarkOrange : Color.FromArgb(0, 146, 108);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                service.AdjustStock(product.Id, (int)numChange.Value, cboReason.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Adjust stock"); }
        }
    }
}

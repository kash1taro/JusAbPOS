using System;
using System.Drawing;
using System.Windows.Forms;

namespace JusAbPOS.WinForms
{
    /// <summary>Asks how the customer pays. Card / Mobile pay exactly the total; Cash shows the change.</summary>
    public partial class PaymentForm : Form
    {
        private readonly decimal total;

        public string PaymentMethod { get { return (string)cboMethod.SelectedItem; } }
        public decimal AmountPaid { get { return numPaid.Value; } }

        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(decimal totalDue) : this()
        {
            total = totalDue;
            lblDue.Text = total.ToString("C2");
            numPaid.Value = Math.Min(total, numPaid.Maximum);
            cboMethod.SelectedIndex = 0;      // fires cboMethod_SelectedIndexChanged
            UpdateChange();
        }

        private void cboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cash = PaymentMethod == "Cash";
            numPaid.Enabled = cash;
            if (!cash) numPaid.Value = Math.Min(total, numPaid.Maximum);
            UpdateChange();
        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {
            UpdateChange();
        }

        private void UpdateChange()
        {
            var change = UiHelper.LiveValue(numPaid) - total;
            lblChange.Text = change >= 0 ? change.ToString("C2") : "Short by " + (-change).ToString("C2");
            lblChange.ForeColor = change >= 0 ? Color.FromArgb(0, 146, 108) : Color.FromArgb(206, 38, 38);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var paid = numPaid.Value;                   // reading Value also commits the typed text
            if (paid < total)
            {
                UiHelper.Warn("The amount paid is less than the total.", "Payment");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}

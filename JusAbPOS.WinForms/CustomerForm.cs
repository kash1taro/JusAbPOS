using System;
using System.Windows.Forms;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    public partial class CustomerForm : Form
    {
        private readonly SalesService sales;

        public int CreatedCustomerId { get; private set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(SalesService salesService) : this()
        {
            sales = salesService;
        }

        private void CustomerForm_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CreatedCustomerId = sales.AddCustomer(txtName.Text, txtPhone.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Add customer"); }
        }
    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    public partial class DashboardView : UserControl, IRefreshable
    {
        private readonly User user;
        private readonly DashboardService dashboard = new DashboardService();

        public DashboardView()
        {
            InitializeComponent();
        }

        public DashboardView(User signedInUser) : this()
        {
            user = signedInUser;
            lblWelcome.Text = "Welcome, " + user.FullName;
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            if (user == null) return;              // design-time
            RefreshData();
        }

        public void RefreshData()
        {
            try
            {
                var stats = dashboard.GetStats();
                lblSalesValue.Text = stats.TodaySales.ToString("C2");
                lblOrdersValue.Text = stats.TodayOrders.ToString();
                lblLowValue.Text = stats.LowStockCount.ToString();
                lblActiveValue.Text = stats.ActiveProducts.ToString();
                gridLow.DataSource = new BindingList<LowStockItem>(dashboard.GetLowStock());
                lblWelcome.Text = "Welcome, " + user.FullName;
                lblWelcome.ForeColor = Color.FromArgb(108, 117, 125);
            }
            catch (Exception ex)
            {
                AppLog.Write(ex);
                lblWelcome.Text = "Could not load dashboard data. Check the database connection.";
                lblWelcome.ForeColor = Color.FromArgb(206, 38, 38);
            }
        }
    }
}

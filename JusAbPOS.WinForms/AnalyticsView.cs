using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    /// <summary>Sales Analytics (Admin / Manager): daily sales, top products, sales by category. Layout: AnalyticsView.Designer.cs</summary>
    public partial class AnalyticsView : UserControl, IRefreshable
    {
        private readonly ReportingService reports;

        public AnalyticsView()
        {
            InitializeComponent();
        }

        public AnalyticsView(User user) : this()
        {
            reports = new ReportingService(user);
            dtTo.Value = DateTime.Today;
            dtFrom.Value = DateTime.Today.AddDays(-30);
        }

        private void AnalyticsView_Load(object sender, EventArgs e)
        {
            if (reports == null) return;           // design-time
            LoadReports();
        }

        public void RefreshData() { LoadReports(); }

        private void btnRefresh_Click(object sender, EventArgs e) { LoadReports(); }

        private void LoadReports()
        {
            try
            {
                var daily = reports.DailySales(dtFrom.Value, dtTo.Value);
                gridDaily.DataSource = new BindingList<DailySalesRow>(daily);
                gridTop.DataSource = new BindingList<TopProductRow>(reports.TopProducts(dtFrom.Value, dtTo.Value, 10));
                gridCategory.DataSource = new BindingList<CategorySalesRow>(reports.SalesByCategory(dtFrom.Value, dtTo.Value));

                lblSummary.Text = "Orders: " + daily.Sum(d => d.OrderCount) + "    |    Revenue: " + daily.Sum(d => d.Revenue).ToString("C2") +
                                  (daily.Count == 0 ? "    (no completed sales in this range)" : "");
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Sales Analytics"); }
        }
    }
}

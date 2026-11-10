using System;
using System.Drawing;
using System.Windows.Forms;
using JusAbPOS.Domain;

namespace JusAbPOS.WinForms
{
    /// <summary>
    /// Application shell: sidebar navigation + one embedded screen at a time.
    /// Layout lives in MainForm.Designer.cs. Screens are UserControls (DashboardView, PosView, InventoryView ...).
    /// </summary>
    public partial class MainForm : Form
    {
        private static readonly Color ActiveNav = Color.FromArgb(62, 104, 186);
        private static readonly Color NormalNav = Color.FromArgb(30, 58, 120);

        private readonly User user;
        private UserControl currentView;

        public bool LoggedOut { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User signedInUser) : this()
        {
            user = signedInUser;
            lblUser.Text = user.FullName + "\n" + user.Role;

            // Role-aware navigation. The service layer re-checks every call, so hiding a button is only a convenience.
            btnInventory.Visible = user.CanManageInventory;
            btnAnalytics.Visible = user.CanViewReports;
            btnUsers.Visible = user.Role == UserRole.Admin;

            WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (user == null) return;               // design-time
            Navigate(new DashboardView(user), btnDashboard);
        }

        // ------------------------------------------------------------ navigation
        private void btnDashboard_Click(object sender, EventArgs e) { Navigate(new DashboardView(user), btnDashboard); }
        private void btnPos_Click(object sender, EventArgs e) { Navigate(new PosView(user), btnPos); }
        private void btnInventory_Click(object sender, EventArgs e) { Navigate(new InventoryView(user), btnInventory); }
        private void btnAnalytics_Click(object sender, EventArgs e) { Navigate(new AnalyticsView(user), btnAnalytics); }
        private void btnUsers_Click(object sender, EventArgs e) { Navigate(new UsersView(user), btnUsers); }

        private void Navigate(UserControl view, Button navButton)
        {
            var old = currentView;
            view.Dock = DockStyle.Fill;
            panelContent.Controls.Add(view);
            currentView = view;
            if (old != null)
            {
                panelContent.Controls.Remove(old);
                old.Dispose();
            }

            foreach (Control c in panelSidebar.Controls)
            {
                var b = c as Button;
                if (b != null) b.BackColor = NormalNav;
            }
            navButton.BackColor = ActiveNav;
        }

        // ------------------------------------------------------------ keyboard: F2 = POS, F5 = refresh, F9 = checkout
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (user != null)
            {
                if (keyData == Keys.F2) { btnPos.PerformClick(); return true; }
                if (keyData == Keys.F5)
                {
                    var refreshable = currentView as IRefreshable;
                    if (refreshable != null) { refreshable.RefreshData(); return true; }
                }
                if (keyData == Keys.F9)
                {
                    var pos = currentView as PosView;
                    if (pos != null) { pos.Checkout(); return true; }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // ------------------------------------------------------------ log out / exit
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (!UiHelper.Confirm("Log out of JusAbPOS?", "Log out")) return;
            LoggedOut = true;
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (user == null || LoggedOut || e.CloseReason != CloseReason.UserClosing) return;
            if (!UiHelper.Confirm("Exit JusAbPOS?", "Exit")) e.Cancel = true;
        }
    }
}

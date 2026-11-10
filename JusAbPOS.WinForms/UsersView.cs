using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    /// <summary>Users &amp; Roles (Admin only). Layout: UsersView.Designer.cs</summary>
    public partial class UsersView : UserControl, IRefreshable
    {
        private readonly UserService service;
        private int? selectAfterLoad;

        public UsersView()
        {
            InitializeComponent();
        }

        public UsersView(User admin) : this()
        {
            service = new UserService(admin);
        }

        private void UsersView_Load(object sender, EventArgs e)
        {
            if (service == null) return;           // design-time
            UpdateButtons();
            LoadRows();
        }

        public void RefreshData() { LoadRows(); }

        private UserAccount Selected()
        {
            return gridUsers.CurrentRow == null ? null : gridUsers.CurrentRow.DataBoundItem as UserAccount;
        }

        private void UpdateButtons()
        {
            var has = Selected() != null;
            btnEdit.Enabled = btnToggle.Enabled = btnReset.Enabled = has;
        }

        private void LoadRows()
        {
            try
            {
                var keepId = selectAfterLoad ?? (Selected() != null ? (int?)Selected().Id : null);
                selectAfterLoad = null;

                var rows = service.GetAll();
                gridUsers.DataSource = new BindingList<UserAccount>(rows);

                if (keepId.HasValue)
                    foreach (DataGridViewRow row in gridUsers.Rows)
                        if (((UserAccount)row.DataBoundItem).Id == keepId.Value)
                        {
                            row.Selected = true;
                            gridUsers.CurrentCell = row.Cells[0];
                            break;
                        }

                lblSummary.Text = rows.Count + " user(s)   |   " + rows.Count(x => x.IsActive) + " active   (inactive users are grey and cannot sign in)";
                UpdateButtons();
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Users"); }
        }

        private void gridUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gridUsers.Rows)
            {
                var u = row.DataBoundItem as UserAccount;
                if (u != null && !u.IsActive) row.DefaultCellStyle.ForeColor = Color.Gray;
            }
        }

        private void gridUsers_SelectionChanged(object sender, EventArgs e) { UpdateButtons(); }
        private void gridUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex >= 0) EditSelected(); }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new UserEditorForm(service, UserEditorMode.Create, null))
                if (dialog.ShowDialog(FindForm()) == DialogResult.OK) LoadRows();
        }

        private void btnEdit_Click(object sender, EventArgs e) { EditSelected(); }

        private void EditSelected()
        {
            var u = Selected();
            if (u == null) return;
            using (var dialog = new UserEditorForm(service, UserEditorMode.Edit, u))
                if (dialog.ShowDialog(FindForm()) == DialogResult.OK) { selectAfterLoad = u.Id; LoadRows(); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var u = Selected();
            if (u == null) return;
            using (var dialog = new UserEditorForm(service, UserEditorMode.ResetPassword, u))
                if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
                    MessageBox.Show("Password changed for '" + u.Username + "'.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            var u = Selected();
            if (u == null) return;
            var target = !u.IsActive;
            var text = target ? "Activate '" + u.Username + "'?" : "Deactivate '" + u.Username + "'? They will no longer be able to sign in.";
            if (!UiHelper.Confirm(text, "Users")) return;
            try
            {
                service.SetActive(u.Id, target);
                selectAfterLoad = u.Id;
                LoadRows();
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Users"); }
        }
    }
}

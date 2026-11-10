using System;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    public enum UserEditorMode { Create, Edit, ResetPassword }

    /// <summary>One dialog for three jobs: add a user, edit name/role, or reset a password.</summary>
    public partial class UserEditorForm : Form
    {
        private readonly UserService service;
        private readonly UserEditorMode mode;
        private readonly UserAccount account;

        public UserEditorForm()
        {
            InitializeComponent();
        }

        public UserEditorForm(UserService userService, UserEditorMode editorMode, UserAccount existing) : this()
        {
            service = userService;
            mode = editorMode;
            account = existing;

            var passwordVisible = mode != UserEditorMode.Edit;
            lblPassword.Visible = txtPassword.Visible = lblConfirm.Visible = txtConfirm.Visible = lblHint.Visible = passwordVisible;
            txtUsername.Enabled = mode == UserEditorMode.Create;
            txtFullName.Enabled = cboRole.Enabled = mode != UserEditorMode.ResetPassword;

            switch (mode)
            {
                case UserEditorMode.Create: Text = "Add User"; break;
                case UserEditorMode.Edit: Text = "Edit User"; break;
                default: Text = "Reset Password"; break;
            }
            if (existing != null)
            {
                txtUsername.Text = existing.Username;
                txtFullName.Text = existing.FullName;
            }
        }

        private void UserEditorForm_Load(object sender, EventArgs e)
        {
            if (service == null) return;                // design-time
            try
            {
                cboRole.DisplayMember = "Name";
                cboRole.ValueMember = "Id";
                cboRole.DataSource = service.GetRoles();
                if (account != null) cboRole.SelectedValue = account.RoleId;
                else if (cboRole.Items.Count > 0) cboRole.SelectedIndex = cboRole.Items.Count - 1;   // default: least privileged (Cashier)
            }
            catch (Exception ex)
            {
                UiHelper.ShowError(ex, "Users");
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var roleId = cboRole.SelectedValue is int ? (int)cboRole.SelectedValue : 0;
                if (mode != UserEditorMode.Edit && txtPassword.Text != txtConfirm.Text)
                    throw new ArgumentException("The two passwords do not match.");

                switch (mode)
                {
                    case UserEditorMode.Create: service.Create(txtUsername.Text, txtFullName.Text, roleId, txtPassword.Text); break;
                    case UserEditorMode.Edit: service.Update(account.Id, txtFullName.Text, roleId); break;
                    default: service.ResetPassword(account.Id, txtPassword.Text); break;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Users"); }
        }
    }
}

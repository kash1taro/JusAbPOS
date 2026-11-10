using System;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    /// <summary>Layout lives in LoginForm.Designer.cs - open this form in the Visual Studio designer to change it.</summary>
    public partial class LoginForm : Form
    {
        /// <summary>Set after a successful sign-in (DialogResult.OK).</summary>
        public User AuthenticatedUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            try
            {
                UseWaitCursor = true;
                btnLogin.Enabled = false;

                var user = new AuthService().Login(txtUsername.Text, txtPassword.Text);
                if (user == null)
                {
                    // One generic message: never reveal whether the username exists.
                    lblStatus.Text = "Invalid credentials or inactive user.";
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                AuthenticatedUser = user;
                DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                lblStatus.Text = ex.Message;
            }
            catch (Exception ex)
            {
                AppLog.Write(ex);
                lblStatus.Text = "Unable to connect. Contact the administrator.";
            }
            finally
            {
                UseWaitCursor = false;
                btnLogin.Enabled = true;
            }
        }
    }
}

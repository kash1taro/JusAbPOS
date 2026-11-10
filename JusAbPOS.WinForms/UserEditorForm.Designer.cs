namespace JusAbPOS.WinForms
{
    partial class UserEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Text = "Username *";
            this.lblUsername.Location = new System.Drawing.Point(24, 26);
            this.lblUsername.AutoSize = true;
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Name = "lblUsername";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 22);
            this.txtUsername.Size = new System.Drawing.Size(236, 23);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Name = "txtUsername";
            // 
            // lblFullName
            // 
            this.lblFullName.Text = "Full name *";
            this.lblFullName.Location = new System.Drawing.Point(24, 66);
            this.lblFullName.AutoSize = true;
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Name = "lblFullName";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(170, 62);
            this.txtFullName.Size = new System.Drawing.Size(236, 23);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.TabIndex = 3;
            this.txtFullName.Name = "txtFullName";
            // 
            // lblRole
            // 
            this.lblRole.Text = "Role *";
            this.lblRole.Location = new System.Drawing.Point(24, 106);
            this.lblRole.AutoSize = true;
            this.lblRole.TabIndex = 4;
            this.lblRole.Name = "lblRole";
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(170, 102);
            this.cboRole.Size = new System.Drawing.Size(236, 23);
            this.cboRole.TabIndex = 5;
            this.cboRole.Name = "cboRole";
            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Password *";
            this.lblPassword.Location = new System.Drawing.Point(24, 150);
            this.lblPassword.AutoSize = true;
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Name = "lblPassword";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 146);
            this.txtPassword.Size = new System.Drawing.Size(236, 23);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.MaxLength = 100;
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Name = "txtPassword";
            // 
            // lblConfirm
            // 
            this.lblConfirm.Text = "Confirm password *";
            this.lblConfirm.Location = new System.Drawing.Point(24, 190);
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.TabIndex = 8;
            this.lblConfirm.Name = "lblConfirm";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(170, 186);
            this.txtConfirm.Size = new System.Drawing.Size(236, 23);
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.MaxLength = 100;
            this.txtConfirm.TabIndex = 9;
            this.txtConfirm.Name = "txtConfirm";
            // 
            // lblHint
            // 
            this.lblHint.Text = "At least 8 characters, with a letter and a number.";
            this.lblHint.Location = new System.Drawing.Point(24, 228);
            this.lblHint.AutoSize = false;
            this.lblHint.Size = new System.Drawing.Size(382, 22);
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHint.TabIndex = 10;
            this.lblHint.Name = "lblHint";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Location = new System.Drawing.Point(170, 290);
            this.btnSave.Size = new System.Drawing.Size(120, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(120, 128, 140);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Location = new System.Drawing.Point(300, 290);
            this.btnCancel.Size = new System.Drawing.Size(106, 42);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Name = "btnCancel";
            // 
            // UserEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 360);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = System.Drawing.Color.White;
            this.Text = "User";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Load += new System.EventHandler(this.UserEditorForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

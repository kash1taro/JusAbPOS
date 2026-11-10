namespace JusAbPOS.WinForms
{
    partial class PaymentForm
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
            this.lblDueCaption = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.lblMethodCaption = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.lblPaidCaption = new System.Windows.Forms.Label();
            this.numPaid = new System.Windows.Forms.NumericUpDown();
            this.lblChangeCaption = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDueCaption
            // 
            this.lblDueCaption.Text = "Amount due";
            this.lblDueCaption.Location = new System.Drawing.Point(24, 18);
            this.lblDueCaption.AutoSize = true;
            this.lblDueCaption.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblDueCaption.TabIndex = 0;
            this.lblDueCaption.Name = "lblDueCaption";
            // 
            // lblDue
            // 
            this.lblDue.Text = "P0.00";
            this.lblDue.Location = new System.Drawing.Point(24, 38);
            this.lblDue.AutoSize = false;
            this.lblDue.Size = new System.Drawing.Size(332, 44);
            this.lblDue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.ForeColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDue.TabIndex = 1;
            this.lblDue.Name = "lblDue";
            // 
            // lblMethodCaption
            // 
            this.lblMethodCaption.Text = "Payment method";
            this.lblMethodCaption.Location = new System.Drawing.Point(24, 98);
            this.lblMethodCaption.AutoSize = true;
            this.lblMethodCaption.TabIndex = 2;
            this.lblMethodCaption.Name = "lblMethodCaption";
            // 
            // cboMethod
            // 
            this.cboMethod.Items.AddRange(new object[] {
                "Cash",
                "Card",
                "Mobile"});
            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.FormattingEnabled = true;
            this.cboMethod.Location = new System.Drawing.Point(24, 120);
            this.cboMethod.Size = new System.Drawing.Size(332, 23);
            this.cboMethod.TabIndex = 3;
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.SelectedIndexChanged += new System.EventHandler(this.cboMethod_SelectedIndexChanged);
            // 
            // lblPaidCaption
            // 
            this.lblPaidCaption.Text = "Amount paid";
            this.lblPaidCaption.Location = new System.Drawing.Point(24, 160);
            this.lblPaidCaption.AutoSize = true;
            this.lblPaidCaption.TabIndex = 4;
            this.lblPaidCaption.Name = "lblPaidCaption";
            // 
            // numPaid
            // 
            this.numPaid.Location = new System.Drawing.Point(24, 182);
            this.numPaid.Size = new System.Drawing.Size(332, 23);
            this.numPaid.Maximum = new decimal(new int[] { 1410065407, 2, 0, 131072 });
            this.numPaid.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numPaid.DecimalPlaces = 2;
            this.numPaid.ThousandsSeparator = true;
            this.numPaid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaid.TabIndex = 5;
            this.numPaid.Name = "numPaid";
            this.numPaid.ValueChanged += new System.EventHandler(this.numPaid_ValueChanged);
            this.numPaid.TextChanged += new System.EventHandler(this.numPaid_ValueChanged);
            // 
            // lblChangeCaption
            // 
            this.lblChangeCaption.Text = "Change";
            this.lblChangeCaption.Location = new System.Drawing.Point(24, 228);
            this.lblChangeCaption.AutoSize = true;
            this.lblChangeCaption.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblChangeCaption.TabIndex = 6;
            this.lblChangeCaption.Name = "lblChangeCaption";
            // 
            // lblChange
            // 
            this.lblChange.Text = "P0.00";
            this.lblChange.Location = new System.Drawing.Point(24, 248);
            this.lblChange.AutoSize = false;
            this.lblChange.Size = new System.Drawing.Size(332, 30);
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChange.TabIndex = 7;
            this.lblChange.Name = "lblChange";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Text = "Confirm payment";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Location = new System.Drawing.Point(24, 296);
            this.btnOk.Size = new System.Drawing.Size(200, 42);
            this.btnOk.TabIndex = 8;
            this.btnOk.Name = "btnOk";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(236, 296);
            this.btnCancel.Size = new System.Drawing.Size(120, 42);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Name = "btnCancel";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 350);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = System.Drawing.Color.White;
            this.Text = "Payment";
            this.AcceptButton = this.btnOk;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblDueCaption);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lblMethodCaption);
            this.Controls.Add(this.cboMethod);
            this.Controls.Add(this.lblPaidCaption);
            this.Controls.Add(this.numPaid);
            this.Controls.Add(this.lblChangeCaption);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDueCaption;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label lblMethodCaption;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label lblPaidCaption;
        private System.Windows.Forms.NumericUpDown numPaid;
        private System.Windows.Forms.Label lblChangeCaption;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}

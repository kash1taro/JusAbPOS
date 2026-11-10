namespace JusAbPOS.WinForms
{
    partial class StockAdjustForm
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
            this.lblProductCaption = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCurrentCaption = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblChangeCaption = new System.Windows.Forms.Label();
            this.numChange = new System.Windows.Forms.NumericUpDown();
            this.lblReasonCaption = new System.Windows.Forms.Label();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.lblNewCaption = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numChange)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductCaption
            // 
            this.lblProductCaption.Text = "Product";
            this.lblProductCaption.Location = new System.Drawing.Point(24, 22);
            this.lblProductCaption.AutoSize = true;
            this.lblProductCaption.TabIndex = 0;
            this.lblProductCaption.Name = "lblProductCaption";
            // 
            // lblProduct
            // 
            this.lblProduct.Text = "";
            this.lblProduct.Location = new System.Drawing.Point(170, 22);
            this.lblProduct.AutoSize = false;
            this.lblProduct.Size = new System.Drawing.Size(246, 20);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Name = "lblProduct";
            // 
            // lblCurrentCaption
            // 
            this.lblCurrentCaption.Text = "Current stock";
            this.lblCurrentCaption.Location = new System.Drawing.Point(24, 58);
            this.lblCurrentCaption.AutoSize = true;
            this.lblCurrentCaption.TabIndex = 2;
            this.lblCurrentCaption.Name = "lblCurrentCaption";
            // 
            // lblCurrent
            // 
            this.lblCurrent.Text = "";
            this.lblCurrent.Location = new System.Drawing.Point(170, 58);
            this.lblCurrent.AutoSize = false;
            this.lblCurrent.Size = new System.Drawing.Size(246, 20);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Name = "lblCurrent";
            // 
            // lblChangeCaption
            // 
            this.lblChangeCaption.Text = "Change (+ / -)";
            this.lblChangeCaption.Location = new System.Drawing.Point(24, 98);
            this.lblChangeCaption.AutoSize = true;
            this.lblChangeCaption.TabIndex = 4;
            this.lblChangeCaption.Name = "lblChangeCaption";
            // 
            // numChange
            // 
            this.numChange.Location = new System.Drawing.Point(170, 94);
            this.numChange.Size = new System.Drawing.Size(246, 23);
            this.numChange.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numChange.Minimum = new decimal(new int[] { 100000, 0, 0, -2147483648 });
            this.numChange.Value = new decimal(new int[] { 0, 0, 0, 0 });
            this.numChange.TabIndex = 5;
            this.numChange.Name = "numChange";
            this.numChange.ValueChanged += new System.EventHandler(this.numChange_ValueChanged);
            this.numChange.TextChanged += new System.EventHandler(this.numChange_ValueChanged);
            // 
            // lblReasonCaption
            // 
            this.lblReasonCaption.Text = "Reason *";
            this.lblReasonCaption.Location = new System.Drawing.Point(24, 142);
            this.lblReasonCaption.AutoSize = true;
            this.lblReasonCaption.TabIndex = 6;
            this.lblReasonCaption.Name = "lblReasonCaption";
            // 
            // cboReason
            // 
            this.cboReason.Items.AddRange(new object[] {
                "Restock / delivery received",
                "Damaged",
                "Expired",
                "Inventory count correction",
                "Returned to supplier"});
            this.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboReason.FormattingEnabled = true;
            this.cboReason.Location = new System.Drawing.Point(170, 138);
            this.cboReason.Size = new System.Drawing.Size(246, 23);
            this.cboReason.MaxLength = 200;
            this.cboReason.TabIndex = 7;
            this.cboReason.Name = "cboReason";
            // 
            // lblNewCaption
            // 
            this.lblNewCaption.Text = "New stock";
            this.lblNewCaption.Location = new System.Drawing.Point(24, 186);
            this.lblNewCaption.AutoSize = true;
            this.lblNewCaption.TabIndex = 8;
            this.lblNewCaption.Name = "lblNewCaption";
            // 
            // lblNew
            // 
            this.lblNew.Text = "";
            this.lblNew.Location = new System.Drawing.Point(170, 182);
            this.lblNew.AutoSize = false;
            this.lblNew.Size = new System.Drawing.Size(246, 30);
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNew.TabIndex = 9;
            this.lblNew.Name = "lblNew";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Location = new System.Drawing.Point(170, 250);
            this.btnApply.Size = new System.Drawing.Size(120, 42);
            this.btnApply.TabIndex = 10;
            this.btnApply.Name = "btnApply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(300, 250);
            this.btnCancel.Size = new System.Drawing.Size(116, 42);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Name = "btnCancel";
            // 
            // StockAdjustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 330);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = System.Drawing.Color.White;
            this.Text = "Adjust Stock";
            this.AcceptButton = this.btnApply;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblProductCaption);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCurrentCaption);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblChangeCaption);
            this.Controls.Add(this.numChange);
            this.Controls.Add(this.lblReasonCaption);
            this.Controls.Add(this.cboReason);
            this.Controls.Add(this.lblNewCaption);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.numChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblProductCaption;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCurrentCaption;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblChangeCaption;
        private System.Windows.Forms.NumericUpDown numChange;
        private System.Windows.Forms.Label lblReasonCaption;
        private System.Windows.Forms.ComboBox cboReason;
        private System.Windows.Forms.Label lblNewCaption;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}

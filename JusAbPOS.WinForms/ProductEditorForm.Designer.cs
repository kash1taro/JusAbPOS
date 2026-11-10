namespace JusAbPOS.WinForms
{
    partial class ProductEditorForm
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
            this.lblSku = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCost = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblReorder = new System.Windows.Forms.Label();
            this.numReorder = new System.Windows.Forms.NumericUpDown();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSku
            // 
            this.lblSku.Text = "SKU *";
            this.lblSku.Location = new System.Drawing.Point(24, 26);
            this.lblSku.AutoSize = true;
            this.lblSku.TabIndex = 0;
            this.lblSku.Name = "lblSku";
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(170, 22);
            this.txtSku.Size = new System.Drawing.Size(306, 23);
            this.txtSku.MaxLength = 30;
            this.txtSku.TabIndex = 1;
            this.txtSku.Name = "txtSku";
            // 
            // lblBarcode
            // 
            this.lblBarcode.Text = "Barcode";
            this.lblBarcode.Location = new System.Drawing.Point(24, 66);
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Name = "lblBarcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(170, 62);
            this.txtBarcode.Size = new System.Drawing.Size(306, 23);
            this.txtBarcode.MaxLength = 50;
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.Name = "txtBarcode";
            // 
            // lblName
            // 
            this.lblName.Text = "Product name *";
            this.lblName.Location = new System.Drawing.Point(24, 106);
            this.lblName.AutoSize = true;
            this.lblName.TabIndex = 4;
            this.lblName.Name = "lblName";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 102);
            this.txtName.Size = new System.Drawing.Size(306, 23);
            this.txtName.MaxLength = 150;
            this.txtName.TabIndex = 5;
            this.txtName.Name = "txtName";
            // 
            // lblCategory
            // 
            this.lblCategory.Text = "Category *";
            this.lblCategory.Location = new System.Drawing.Point(24, 146);
            this.lblCategory.AutoSize = true;
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Name = "lblCategory";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(170, 142);
            this.cboCategory.Size = new System.Drawing.Size(306, 23);
            this.cboCategory.TabIndex = 7;
            this.cboCategory.Name = "cboCategory";
            // 
            // lblPrice
            // 
            this.lblPrice.Text = "Selling price";
            this.lblPrice.Location = new System.Drawing.Point(24, 186);
            this.lblPrice.AutoSize = true;
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Name = "lblPrice";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(170, 182);
            this.numPrice.Size = new System.Drawing.Size(306, 23);
            this.numPrice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 131072 });
            this.numPrice.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.ThousandsSeparator = true;
            this.numPrice.Value = new decimal(new int[] { 0, 0, 0, 0 });
            this.numPrice.TabIndex = 9;
            this.numPrice.Name = "numPrice";
            // 
            // lblCost
            // 
            this.lblCost.Text = "Cost";
            this.lblCost.Location = new System.Drawing.Point(24, 226);
            this.lblCost.AutoSize = true;
            this.lblCost.TabIndex = 10;
            this.lblCost.Name = "lblCost";
            // 
            // numCost
            // 
            this.numCost.Location = new System.Drawing.Point(170, 222);
            this.numCost.Size = new System.Drawing.Size(306, 23);
            this.numCost.Maximum = new decimal(new int[] { 1410065407, 2, 0, 131072 });
            this.numCost.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numCost.DecimalPlaces = 2;
            this.numCost.ThousandsSeparator = true;
            this.numCost.Value = new decimal(new int[] { 0, 0, 0, 0 });
            this.numCost.TabIndex = 11;
            this.numCost.Name = "numCost";
            // 
            // lblStock
            // 
            this.lblStock.Text = "Opening stock";
            this.lblStock.Location = new System.Drawing.Point(24, 266);
            this.lblStock.AutoSize = true;
            this.lblStock.TabIndex = 12;
            this.lblStock.Name = "lblStock";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(170, 262);
            this.numStock.Size = new System.Drawing.Size(306, 23);
            this.numStock.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numStock.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numStock.Value = new decimal(new int[] { 0, 0, 0, 0 });
            this.numStock.TabIndex = 13;
            this.numStock.Name = "numStock";
            // 
            // lblReorder
            // 
            this.lblReorder.Text = "Reorder level";
            this.lblReorder.Location = new System.Drawing.Point(24, 306);
            this.lblReorder.AutoSize = true;
            this.lblReorder.TabIndex = 14;
            this.lblReorder.Name = "lblReorder";
            // 
            // numReorder
            // 
            this.numReorder.Location = new System.Drawing.Point(170, 302);
            this.numReorder.Size = new System.Drawing.Size(306, 23);
            this.numReorder.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numReorder.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numReorder.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.numReorder.TabIndex = 15;
            this.numReorder.Name = "numReorder";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(170, 342);
            this.chkActive.Text = "Active (available for sale)";
            this.chkActive.TabIndex = 16;
            this.chkActive.Name = "chkActive";
            // 
            // lblImage
            // 
            this.lblImage.Text = "Image (jpg/png, 2 MB)";
            this.lblImage.Location = new System.Drawing.Point(24, 388);
            this.lblImage.AutoSize = true;
            this.lblImage.TabIndex = 17;
            this.lblImage.Name = "lblImage";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(170, 380);
            this.picture.Size = new System.Drawing.Size(110, 110);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabStop = false;
            this.picture.TabIndex = 18;
            this.picture.Name = "picture";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Location = new System.Drawing.Point(292, 380);
            this.btnBrowse.Size = new System.Drawing.Size(100, 32);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.FromArgb(120, 128, 140);
            this.btnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Text = "Remove";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Location = new System.Drawing.Point(292, 420);
            this.btnRemoveImage.Size = new System.Drawing.Size(100, 32);
            this.btnRemoveImage.TabIndex = 20;
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
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
            this.btnSave.Location = new System.Drawing.Point(170, 520);
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 21;
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
            this.btnCancel.Location = new System.Drawing.Point(330, 520);
            this.btnCancel.Size = new System.Drawing.Size(146, 42);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Name = "btnCancel";
            // 
            // ProductEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = System.Drawing.Color.White;
            this.Text = "Product";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.numReorder);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Load += new System.EventHandler(this.ProductEditorForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.NumericUpDown numReorder;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

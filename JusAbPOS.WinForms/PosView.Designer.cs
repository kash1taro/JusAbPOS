namespace JusAbPOS.WinForms
{
    partial class PosView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelProducts = new System.Windows.Forms.Panel();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.colSku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelScan = new System.Windows.Forms.Panel();
            this.lblScan = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelGap = new System.Windows.Forms.Panel();
            this.panelCart = new System.Windows.Forms.Panel();
            this.gridCart = new System.Windows.Forms.DataGridView();
            this.colCItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTotals = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.rowTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.rowTax = new System.Windows.Forms.Panel();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxCaption = new System.Windows.Forms.Label();
            this.rowSubtotal = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalCaption = new System.Windows.Forms.Label();
            this.rowDiscount = new System.Windows.Forms.Panel();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.rowCustomer = new System.Windows.Forms.Panel();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.panelCartTools = new System.Windows.Forms.Panel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.panelProducts.SuspendLayout();
            this.panelScan.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.panelTotals.SuspendLayout();
            this.rowTotal.SuspendLayout();
            this.rowTax.SuspendLayout();
            this.rowSubtotal.SuspendLayout();
            this.rowDiscount.SuspendLayout();
            this.rowCustomer.SuspendLayout();
            this.panelCartTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.TabIndex = 0;
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Controls.Add(this.gridProducts);
            this.panelProducts.Controls.Add(this.panelScan);
            // 
            // gridProducts
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(246, 248, 252);
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colSku,
                this.colProduct,
                this.colPrice,
                this.colStock});
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducts.AutoGenerateColumns = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.BackgroundColor = System.Drawing.Color.White;
            this.gridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProducts.ColumnHeadersHeight = 32;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.GridColor = System.Drawing.Color.FromArgb(226, 230, 238);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.TabIndex = 0;
            this.gridProducts.RowTemplate.Height = 26;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellDoubleClick);
            this.gridProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridProducts_DataBindingComplete);
            this.gridProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridProducts_KeyDown);
            // 
            // colSku
            // 
            this.colSku.DataPropertyName = "Sku";
            this.colSku.HeaderText = "SKU";
            this.colSku.Name = "colSku";
            this.colSku.ReadOnly = true;
            this.colSku.FillWeight = 14F;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "Name";
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.FillWeight = 52F;
            // 
            // colPrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.FillWeight = 17F;
            // 
            // colStock
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStock.DataPropertyName = "StockQty";
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.FillWeight = 17F;
            // 
            // panelScan
            // 
            this.panelScan.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.panelScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelScan.Size = new System.Drawing.Size(0, 112);
            this.panelScan.TabIndex = 1;
            this.panelScan.Name = "panelScan";
            this.panelScan.Controls.Add(this.lblScan);
            this.panelScan.Controls.Add(this.txtScan);
            this.panelScan.Controls.Add(this.lblFind);
            this.panelScan.Controls.Add(this.txtFind);
            this.panelScan.Controls.Add(this.btnSearch);
            this.panelScan.Controls.Add(this.lblQty);
            this.panelScan.Controls.Add(this.numQty);
            this.panelScan.Controls.Add(this.btnAdd);
            // 
            // lblScan
            // 
            this.lblScan.Text = "Scan barcode / enter SKU, then press Enter:";
            this.lblScan.Location = new System.Drawing.Point(0, 6);
            this.lblScan.AutoSize = true;
            this.lblScan.TabIndex = 0;
            this.lblScan.Name = "lblScan";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(0, 28);
            this.txtScan.Size = new System.Drawing.Size(340, 23);
            this.txtScan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScan.TabIndex = 1;
            this.txtScan.Name = "txtScan";
            this.txtScan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScan_KeyDown);
            // 
            // lblFind
            // 
            this.lblFind.Text = "Find:";
            this.lblFind.Location = new System.Drawing.Point(0, 80);
            this.lblFind.AutoSize = true;
            this.lblFind.TabIndex = 2;
            this.lblFind.Name = "lblFind";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(40, 76);
            this.txtFind.Size = new System.Drawing.Size(210, 23);
            this.txtFind.TabIndex = 3;
            this.txtFind.Name = "txtFind";
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Location = new System.Drawing.Point(258, 74);
            this.btnSearch.Size = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblQty
            // 
            this.lblQty.Text = "Qty:";
            this.lblQty.Location = new System.Drawing.Point(352, 80);
            this.lblQty.AutoSize = true;
            this.lblQty.TabIndex = 5;
            this.lblQty.Name = "lblQty";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(384, 76);
            this.numQty.Size = new System.Drawing.Size(64, 23);
            this.numQty.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQty.TabIndex = 6;
            this.numQty.Name = "numQty";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Text = "Add to cart";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Location = new System.Drawing.Point(458, 74);
            this.btnAdd.Size = new System.Drawing.Size(110, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelGap
            // 
            this.panelGap.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.panelGap.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGap.Size = new System.Drawing.Size(14, 0);
            this.panelGap.TabIndex = 1;
            this.panelGap.Name = "panelGap";
            // 
            // panelCart
            // 
            this.panelCart.BackColor = System.Drawing.Color.White;
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCart.Size = new System.Drawing.Size(470, 0);
            this.panelCart.TabIndex = 2;
            this.panelCart.Name = "panelCart";
            this.panelCart.Controls.Add(this.gridCart);
            this.panelCart.Controls.Add(this.panelTotals);
            this.panelCart.Controls.Add(this.panelCartTools);
            // 
            // gridCart
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(246, 248, 252);
            this.gridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCItem,
                this.colCPrice,
                this.colCQty,
                this.colCTotal});
            this.gridCart.AllowUserToAddRows = false;
            this.gridCart.AllowUserToDeleteRows = false;
            this.gridCart.AllowUserToResizeRows = false;
            this.gridCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCart.AutoGenerateColumns = false;
            this.gridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCart.BackgroundColor = System.Drawing.Color.White;
            this.gridCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCart.ColumnHeadersHeight = 32;
            this.gridCart.EnableHeadersVisualStyles = false;
            this.gridCart.GridColor = System.Drawing.Color.FromArgb(226, 230, 238);
            this.gridCart.MultiSelect = false;
            this.gridCart.ReadOnly = true;
            this.gridCart.RowHeadersVisible = false;
            this.gridCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCart.TabIndex = 0;
            this.gridCart.RowTemplate.Height = 26;
            this.gridCart.Name = "gridCart";
            // 
            // colCItem
            // 
            this.colCItem.DataPropertyName = "ProductName";
            this.colCItem.HeaderText = "Item";
            this.colCItem.Name = "colCItem";
            this.colCItem.ReadOnly = true;
            this.colCItem.FillWeight = 46F;
            // 
            // colCPrice
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.colCPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCPrice.DataPropertyName = "UnitPrice";
            this.colCPrice.HeaderText = "Price";
            this.colCPrice.Name = "colCPrice";
            this.colCPrice.ReadOnly = true;
            this.colCPrice.FillWeight = 18F;
            // 
            // colCQty
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCQty.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCQty.DataPropertyName = "Quantity";
            this.colCQty.HeaderText = "Qty";
            this.colCQty.Name = "colCQty";
            this.colCQty.ReadOnly = true;
            this.colCQty.FillWeight = 12F;
            // 
            // colCTotal
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.colCTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.colCTotal.DataPropertyName = "LineTotal";
            this.colCTotal.HeaderText = "Total";
            this.colCTotal.Name = "colCTotal";
            this.colCTotal.ReadOnly = true;
            this.colCTotal.FillWeight = 24F;
            // 
            // panelTotals
            // 
            this.panelTotals.BackColor = System.Drawing.Color.White;
            this.panelTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotals.Padding = new System.Windows.Forms.Padding(16, 6, 16, 14);
            this.panelTotals.Size = new System.Drawing.Size(0, 272);
            this.panelTotals.TabIndex = 1;
            this.panelTotals.Name = "panelTotals";
            this.panelTotals.Controls.Add(this.btnCheckout);
            this.panelTotals.Controls.Add(this.rowTotal);
            this.panelTotals.Controls.Add(this.rowTax);
            this.panelTotals.Controls.Add(this.rowSubtotal);
            this.panelTotals.Controls.Add(this.rowDiscount);
            this.panelTotals.Controls.Add(this.rowCustomer);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Text = "CHECKOUT  (F9)";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckout.Size = new System.Drawing.Size(0, 54);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // rowTotal
            // 
            this.rowTotal.BackColor = System.Drawing.Color.White;
            this.rowTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowTotal.Size = new System.Drawing.Size(0, 56);
            this.rowTotal.TabIndex = 1;
            this.rowTotal.Name = "rowTotal";
            this.rowTotal.Controls.Add(this.lblTotal);
            this.rowTotal.Controls.Add(this.lblTotalCaption);
            // 
            // lblTotal
            // 
            this.lblTotal.Text = "P0.00";
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Name = "lblTotal";
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Text = "TOTAL";
            this.lblTotalCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCaption.AutoSize = false;
            this.lblTotalCaption.Size = new System.Drawing.Size(120, 0);
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalCaption.TabIndex = 1;
            this.lblTotalCaption.Name = "lblTotalCaption";
            // 
            // rowTax
            // 
            this.rowTax.BackColor = System.Drawing.Color.White;
            this.rowTax.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowTax.Size = new System.Drawing.Size(0, 28);
            this.rowTax.TabIndex = 2;
            this.rowTax.Name = "rowTax";
            this.rowTax.Controls.Add(this.lblTax);
            this.rowTax.Controls.Add(this.lblTaxCaption);
            // 
            // lblTax
            // 
            this.lblTax.Text = "P0.00";
            this.lblTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTax.TabIndex = 0;
            this.lblTax.Name = "lblTax";
            // 
            // lblTaxCaption
            // 
            this.lblTaxCaption.Text = "Tax";
            this.lblTaxCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaxCaption.AutoSize = false;
            this.lblTaxCaption.Size = new System.Drawing.Size(120, 0);
            this.lblTaxCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaxCaption.TabIndex = 1;
            this.lblTaxCaption.Name = "lblTaxCaption";
            // 
            // rowSubtotal
            // 
            this.rowSubtotal.BackColor = System.Drawing.Color.White;
            this.rowSubtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowSubtotal.Size = new System.Drawing.Size(0, 28);
            this.rowSubtotal.TabIndex = 3;
            this.rowSubtotal.Name = "rowSubtotal";
            this.rowSubtotal.Controls.Add(this.lblSubtotal);
            this.rowSubtotal.Controls.Add(this.lblSubtotalCaption);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Text = "P0.00";
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Name = "lblSubtotal";
            // 
            // lblSubtotalCaption
            // 
            this.lblSubtotalCaption.Text = "Subtotal";
            this.lblSubtotalCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSubtotalCaption.AutoSize = false;
            this.lblSubtotalCaption.Size = new System.Drawing.Size(120, 0);
            this.lblSubtotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubtotalCaption.TabIndex = 1;
            this.lblSubtotalCaption.Name = "lblSubtotalCaption";
            // 
            // rowDiscount
            // 
            this.rowDiscount.BackColor = System.Drawing.Color.White;
            this.rowDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowDiscount.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.rowDiscount.Size = new System.Drawing.Size(0, 40);
            this.rowDiscount.TabIndex = 4;
            this.rowDiscount.Name = "rowDiscount";
            this.rowDiscount.Controls.Add(this.numDiscount);
            this.rowDiscount.Controls.Add(this.lblDiscount);
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(0, 0);
            this.numDiscount.Size = new System.Drawing.Size(150, 23);
            this.numDiscount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 131072 });
            this.numDiscount.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.ThousandsSeparator = true;
            this.numDiscount.Value = new decimal(new int[] { 0, 0, 0, 0 });
            this.numDiscount.Dock = System.Windows.Forms.DockStyle.Left;
            this.numDiscount.TabIndex = 0;
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            this.numDiscount.TextChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Text = "Discount";
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDiscount.AutoSize = false;
            this.lblDiscount.Size = new System.Drawing.Size(90, 0);
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Name = "lblDiscount";
            // 
            // rowCustomer
            // 
            this.rowCustomer.BackColor = System.Drawing.Color.White;
            this.rowCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowCustomer.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.rowCustomer.Size = new System.Drawing.Size(0, 40);
            this.rowCustomer.TabIndex = 5;
            this.rowCustomer.Name = "rowCustomer";
            this.rowCustomer.Controls.Add(this.cboCustomer);
            this.rowCustomer.Controls.Add(this.btnAddCustomer);
            this.rowCustomer.Controls.Add(this.lblCustomer);
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(0, 0);
            this.cboCustomer.Size = new System.Drawing.Size(100, 23);
            this.cboCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCustomer.TabIndex = 0;
            this.cboCustomer.Name = "cboCustomer";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Text = "+";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddCustomer.Size = new System.Drawing.Size(38, 28);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCustomer.AutoSize = false;
            this.lblCustomer.Size = new System.Drawing.Size(90, 0);
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Name = "lblCustomer";
            // 
            // panelCartTools
            // 
            this.panelCartTools.BackColor = System.Drawing.Color.White;
            this.panelCartTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCartTools.Size = new System.Drawing.Size(0, 48);
            this.panelCartTools.TabIndex = 2;
            this.panelCartTools.Name = "panelCartTools";
            this.panelCartTools.Controls.Add(this.btnPlus);
            this.panelCartTools.Controls.Add(this.btnMinus);
            this.panelCartTools.Controls.Add(this.btnRemove);
            this.panelCartTools.Controls.Add(this.btnClear);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Location = new System.Drawing.Point(10, 8);
            this.btnPlus.Size = new System.Drawing.Size(44, 32);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Location = new System.Drawing.Point(60, 8);
            this.btnMinus.Size = new System.Drawing.Size(44, 32);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(120, 128, 140);
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Location = new System.Drawing.Point(110, 8);
            this.btnRemove.Size = new System.Drawing.Size(90, 32);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(206, 38, 38);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Text = "Clear cart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Location = new System.Drawing.Point(206, 8);
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.Size = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelGap);
            this.Controls.Add(this.panelCart);
            this.Load += new System.EventHandler(this.PosView_Load);

            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.panelCartTools.ResumeLayout(false);
            this.panelCartTools.PerformLayout();
            this.rowCustomer.ResumeLayout(false);
            this.rowCustomer.PerformLayout();
            this.rowDiscount.ResumeLayout(false);
            this.rowDiscount.PerformLayout();
            this.rowSubtotal.ResumeLayout(false);
            this.rowSubtotal.PerformLayout();
            this.rowTax.ResumeLayout(false);
            this.rowTax.PerformLayout();
            this.rowTotal.ResumeLayout(false);
            this.rowTotal.PerformLayout();
            this.panelTotals.ResumeLayout(false);
            this.panelTotals.PerformLayout();
            this.panelCart.ResumeLayout(false);
            this.panelCart.PerformLayout();
            this.panelScan.ResumeLayout(false);
            this.panelScan.PerformLayout();
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.Panel panelScan;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelGap;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.DataGridView gridCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTotal;
        private System.Windows.Forms.Panel panelTotals;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel rowTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Panel rowTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxCaption;
        private System.Windows.Forms.Panel rowSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.Panel rowDiscount;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel rowCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel panelCartTools;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
    }
}

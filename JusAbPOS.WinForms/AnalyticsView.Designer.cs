namespace JusAbPOS.WinForms
{
    partial class AnalyticsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();

            this.tabs = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.gridDaily = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTop = new System.Windows.Forms.TabPage();
            this.gridTop = new System.Windows.Forms.DataGridView();
            this.colTopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.gridCategory = new System.Windows.Forms.DataGridView();
            this.colCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSummary = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.gridDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabDaily.SuspendLayout();
            this.tabTop.SuspendLayout();
            this.tabCategory.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.SelectedIndex = 0;
            this.tabs.TabIndex = 0;
            this.tabs.Name = "tabs";
            this.tabs.Controls.Add(this.tabDaily);
            this.tabs.Controls.Add(this.tabTop);
            this.tabs.Controls.Add(this.tabCategory);
            // 
            // tabDaily
            // 
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDaily.Text = "Daily sales";
            this.tabDaily.UseVisualStyleBackColor = true;
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Controls.Add(this.gridDaily);
            // 
            // gridDaily
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(246, 248, 252);
            this.gridDaily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDate,
                this.colOrders,
                this.colRevenue});
            this.gridDaily.AllowUserToAddRows = false;
            this.gridDaily.AllowUserToDeleteRows = false;
            this.gridDaily.AllowUserToResizeRows = false;
            this.gridDaily.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDaily.AutoGenerateColumns = false;
            this.gridDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDaily.BackgroundColor = System.Drawing.Color.White;
            this.gridDaily.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDaily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDaily.ColumnHeadersHeight = 32;
            this.gridDaily.EnableHeadersVisualStyles = false;
            this.gridDaily.GridColor = System.Drawing.Color.FromArgb(226, 230, 238);
            this.gridDaily.MultiSelect = false;
            this.gridDaily.ReadOnly = true;
            this.gridDaily.RowHeadersVisible = false;
            this.gridDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDaily.TabIndex = 0;
            this.gridDaily.RowTemplate.Height = 26;
            this.gridDaily.Name = "gridDaily";
            // 
            // colDate
            // 
            dataGridViewCellStyle3.Format = "yyyy-MM-dd";
            dataGridViewCellStyle3.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDate.DataPropertyName = "SaleDate";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.FillWeight = 34F;
            // 
            // colOrders
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOrders.DefaultCellStyle = dataGridViewCellStyle4;
            this.colOrders.DataPropertyName = "OrderCount";
            this.colOrders.HeaderText = "Orders";
            this.colOrders.Name = "colOrders";
            this.colOrders.ReadOnly = true;
            this.colOrders.FillWeight = 26F;
            // 
            // colRevenue
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colRevenue.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRevenue.DataPropertyName = "Revenue";
            this.colRevenue.HeaderText = "Revenue";
            this.colRevenue.Name = "colRevenue";
            this.colRevenue.ReadOnly = true;
            this.colRevenue.FillWeight = 40F;
            // 
            // tabTop
            // 
            this.tabTop.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTop.Text = "Top products";
            this.tabTop.UseVisualStyleBackColor = true;
            this.tabTop.Name = "tabTop";
            this.tabTop.Controls.Add(this.gridTop);
            // 
            // gridTop
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(246, 248, 252);
            this.gridTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTopName,
                this.colTopQty,
                this.colTopRevenue});
            this.gridTop.AllowUserToAddRows = false;
            this.gridTop.AllowUserToDeleteRows = false;
            this.gridTop.AllowUserToResizeRows = false;
            this.gridTop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridTop.AutoGenerateColumns = false;
            this.gridTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTop.BackgroundColor = System.Drawing.Color.White;
            this.gridTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTop.ColumnHeadersHeight = 32;
            this.gridTop.EnableHeadersVisualStyles = false;
            this.gridTop.GridColor = System.Drawing.Color.FromArgb(226, 230, 238);
            this.gridTop.MultiSelect = false;
            this.gridTop.ReadOnly = true;
            this.gridTop.RowHeadersVisible = false;
            this.gridTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTop.TabIndex = 0;
            this.gridTop.RowTemplate.Height = 26;
            this.gridTop.Name = "gridTop";
            // 
            // colTopName
            // 
            this.colTopName.DataPropertyName = "ProductName";
            this.colTopName.HeaderText = "Product";
            this.colTopName.Name = "colTopName";
            this.colTopName.ReadOnly = true;
            this.colTopName.FillWeight = 50F;
            // 
            // colTopQty
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTopQty.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTopQty.DataPropertyName = "QtySold";
            this.colTopQty.HeaderText = "Qty sold";
            this.colTopQty.Name = "colTopQty";
            this.colTopQty.ReadOnly = true;
            this.colTopQty.FillWeight = 20F;
            // 
            // colTopRevenue
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.colTopRevenue.DefaultCellStyle = dataGridViewCellStyle9;
            this.colTopRevenue.DataPropertyName = "Revenue";
            this.colTopRevenue.HeaderText = "Revenue";
            this.colTopRevenue.Name = "colTopRevenue";
            this.colTopRevenue.ReadOnly = true;
            this.colTopRevenue.FillWeight = 30F;
            // 
            // tabCategory
            // 
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCategory.Text = "Sales by category";
            this.tabCategory.UseVisualStyleBackColor = true;
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Controls.Add(this.gridCategory);
            // 
            // gridCategory
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(246, 248, 252);
            this.gridCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCatName,
                this.colCatRevenue});
            this.gridCategory.AllowUserToAddRows = false;
            this.gridCategory.AllowUserToDeleteRows = false;
            this.gridCategory.AllowUserToResizeRows = false;
            this.gridCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridCategory.AutoGenerateColumns = false;
            this.gridCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategory.BackgroundColor = System.Drawing.Color.White;
            this.gridCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCategory.ColumnHeadersHeight = 32;
            this.gridCategory.EnableHeadersVisualStyles = false;
            this.gridCategory.GridColor = System.Drawing.Color.FromArgb(226, 230, 238);
            this.gridCategory.MultiSelect = false;
            this.gridCategory.ReadOnly = true;
            this.gridCategory.RowHeadersVisible = false;
            this.gridCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategory.TabIndex = 0;
            this.gridCategory.RowTemplate.Height = 26;
            this.gridCategory.Name = "gridCategory";
            // 
            // colCatName
            // 
            this.colCatName.DataPropertyName = "CategoryName";
            this.colCatName.HeaderText = "Category";
            this.colCatName.Name = "colCatName";
            this.colCatName.ReadOnly = true;
            this.colCatName.FillWeight = 60F;
            // 
            // colCatRevenue
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.colCatRevenue.DefaultCellStyle = dataGridViewCellStyle12;
            this.colCatRevenue.DataPropertyName = "Revenue";
            this.colCatRevenue.HeaderText = "Revenue";
            this.colCatRevenue.Name = "colCatRevenue";
            this.colCatRevenue.ReadOnly = true;
            this.colCatRevenue.FillWeight = 40F;
            // 
            // lblSummary
            // 
            this.lblSummary.Text = "";
            this.lblSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSummary.AutoSize = false;
            this.lblSummary.Size = new System.Drawing.Size(0, 30);
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSummary.BackColor = System.Drawing.Color.FromArgb(235, 238, 245);
            this.lblSummary.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Name = "lblSummary";
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Size = new System.Drawing.Size(0, 50);
            this.panelToolbar.TabIndex = 2;
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Controls.Add(this.lblFrom);
            this.panelToolbar.Controls.Add(this.dtFrom);
            this.panelToolbar.Controls.Add(this.lblTo);
            this.panelToolbar.Controls.Add(this.dtTo);
            this.panelToolbar.Controls.Add(this.btnRefresh);
            // 
            // lblFrom
            // 
            this.lblFrom.Text = "From";
            this.lblFrom.Location = new System.Drawing.Point(0, 16);
            this.lblFrom.AutoSize = true;
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Name = "lblFrom";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(40, 12);
            this.dtFrom.Size = new System.Drawing.Size(120, 23);
            this.dtFrom.TabIndex = 1;
            this.dtFrom.Name = "dtFrom";
            // 
            // lblTo
            // 
            this.lblTo.Text = "To";
            this.lblTo.Location = new System.Drawing.Point(176, 16);
            this.lblTo.AutoSize = true;
            this.lblTo.TabIndex = 2;
            this.lblTo.Name = "lblTo";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(200, 12);
            this.dtTo.Size = new System.Drawing.Size(120, 23);
            this.dtTo.TabIndex = 3;
            this.dtTo.Name = "dtTo";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Location = new System.Drawing.Point(336, 10);
            this.btnRefresh.Size = new System.Drawing.Size(90, 29);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Sales Analytics";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(0, 46);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Name = "lblTitle";
            // 
            // AnalyticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.Size = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.lblTitle);
            this.Load += new System.EventHandler(this.AnalyticsView_Load);

            ((System.ComponentModel.ISupportInitialize)(this.gridDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).EndInit();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.tabCategory.ResumeLayout(false);
            this.tabTop.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.DataGridView gridDaily;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenue;
        private System.Windows.Forms.TabPage tabTop;
        private System.Windows.Forms.DataGridView gridTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopRevenue;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.DataGridView gridCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatRevenue;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
    }
}

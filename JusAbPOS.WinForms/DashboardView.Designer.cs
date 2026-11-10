namespace JusAbPOS.WinForms
{
    partial class DashboardView
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

            this.groupLow = new System.Windows.Forms.GroupBox();
            this.gridLow = new System.Windows.Forms.DataGridView();
            this.colSku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spacer = new System.Windows.Forms.Panel();
            this.tableCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardSales = new System.Windows.Forms.Panel();
            this.lblSalesValue = new System.Windows.Forms.Label();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.accentSales = new System.Windows.Forms.Panel();
            this.cardOrders = new System.Windows.Forms.Panel();
            this.lblOrdersValue = new System.Windows.Forms.Label();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.accentOrders = new System.Windows.Forms.Panel();
            this.cardLow = new System.Windows.Forms.Panel();
            this.lblLowValue = new System.Windows.Forms.Label();
            this.lblLowTitle = new System.Windows.Forms.Label();
            this.accentLow = new System.Windows.Forms.Panel();
            this.cardActive = new System.Windows.Forms.Panel();
            this.lblActiveValue = new System.Windows.Forms.Label();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.accentActive = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.gridLow)).BeginInit();
            this.groupLow.SuspendLayout();
            this.tableCards.SuspendLayout();
            this.cardSales.SuspendLayout();
            this.cardOrders.SuspendLayout();
            this.cardLow.SuspendLayout();
            this.cardActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLow
            // 
            this.groupLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLow.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.groupLow.Text = "Low-stock items (at or below reorder level)";
            this.groupLow.TabIndex = 0;
            this.groupLow.Name = "groupLow";
            this.groupLow.Controls.Add(this.gridLow);
            // 
            // gridLow
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 120);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(246, 248, 252);
            this.gridLow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colSku,
                this.colName,
                this.colStock,
                this.colReorder});
            this.gridLow.AllowUserToAddRows = false;
            this.gridLow.AllowUserToDeleteRows = false;
            this.gridLow.AllowUserToResizeRows = false;
            this.gridLow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridLow.AutoGenerateColumns = false;
            this.gridLow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLow.BackgroundColor = System.Drawing.Color.White;
            this.gridLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridLow.ColumnHeadersHeight = 32;
            this.gridLow.EnableHeadersVisualStyles = false;
            this.gridLow.GridColor = System.Drawing.Color.FromArgb(226, 230, 238);
            this.gridLow.MultiSelect = false;
            this.gridLow.ReadOnly = true;
            this.gridLow.RowHeadersVisible = false;
            this.gridLow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLow.TabIndex = 0;
            this.gridLow.RowTemplate.Height = 26;
            this.gridLow.Name = "gridLow";
            // 
            // colSku
            // 
            this.colSku.DataPropertyName = "Sku";
            this.colSku.HeaderText = "SKU";
            this.colSku.Name = "colSku";
            this.colSku.ReadOnly = true;
            this.colSku.FillWeight = 20F;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Product";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.FillWeight = 50F;
            // 
            // colStock
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.colStock.DataPropertyName = "StockQty";
            this.colStock.HeaderText = "In stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.FillWeight = 15F;
            // 
            // colReorder
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colReorder.DefaultCellStyle = dataGridViewCellStyle4;
            this.colReorder.DataPropertyName = "ReorderLevel";
            this.colReorder.HeaderText = "Reorder level";
            this.colReorder.Name = "colReorder";
            this.colReorder.ReadOnly = true;
            this.colReorder.FillWeight = 15F;
            // 
            // spacer
            // 
            this.spacer.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer.Size = new System.Drawing.Size(0, 14);
            this.spacer.TabIndex = 1;
            this.spacer.Name = "spacer";
            // 
            // tableCards
            // 
            this.tableCards.ColumnCount = 4;
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCards.RowCount = 1;
            this.tableCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCards.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.tableCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableCards.Size = new System.Drawing.Size(0, 120);
            this.tableCards.TabIndex = 2;
            this.tableCards.Name = "tableCards";
            this.tableCards.Controls.Add(this.cardSales, 0, 0);
            this.tableCards.Controls.Add(this.cardOrders, 1, 0);
            this.tableCards.Controls.Add(this.cardLow, 2, 0);
            this.tableCards.Controls.Add(this.cardActive, 3, 0);
            // 
            // cardSales
            // 
            this.cardSales.BackColor = System.Drawing.Color.White;
            this.cardSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSales.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardSales.TabIndex = 0;
            this.cardSales.Name = "cardSales";
            this.cardSales.Controls.Add(this.lblSalesValue);
            this.cardSales.Controls.Add(this.lblSalesTitle);
            this.cardSales.Controls.Add(this.accentSales);
            // 
            // lblSalesValue
            // 
            this.lblSalesValue.Text = "-";
            this.lblSalesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalesValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesValue.ForeColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.lblSalesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSalesValue.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblSalesValue.TabIndex = 0;
            this.lblSalesValue.Name = "lblSalesValue";
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.Text = "Today's sales";
            this.lblSalesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalesTitle.AutoSize = false;
            this.lblSalesTitle.Size = new System.Drawing.Size(0, 34);
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblSalesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSalesTitle.Padding = new System.Windows.Forms.Padding(14, 8, 0, 0);
            this.lblSalesTitle.TabIndex = 1;
            this.lblSalesTitle.Name = "lblSalesTitle";
            // 
            // accentSales
            // 
            this.accentSales.BackColor = System.Drawing.Color.FromArgb(0, 146, 108);
            this.accentSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentSales.Size = new System.Drawing.Size(6, 0);
            this.accentSales.TabIndex = 2;
            this.accentSales.Name = "accentSales";
            // 
            // cardOrders
            // 
            this.cardOrders.BackColor = System.Drawing.Color.White;
            this.cardOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardOrders.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardOrders.TabIndex = 1;
            this.cardOrders.Name = "cardOrders";
            this.cardOrders.Controls.Add(this.lblOrdersValue);
            this.cardOrders.Controls.Add(this.lblOrdersTitle);
            this.cardOrders.Controls.Add(this.accentOrders);
            // 
            // lblOrdersValue
            // 
            this.lblOrdersValue.Text = "-";
            this.lblOrdersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrdersValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersValue.ForeColor = System.Drawing.Color.FromArgb(60, 110, 190);
            this.lblOrdersValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrdersValue.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblOrdersValue.TabIndex = 0;
            this.lblOrdersValue.Name = "lblOrdersValue";
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.Text = "Orders today";
            this.lblOrdersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrdersTitle.AutoSize = false;
            this.lblOrdersTitle.Size = new System.Drawing.Size(0, 34);
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblOrdersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrdersTitle.Padding = new System.Windows.Forms.Padding(14, 8, 0, 0);
            this.lblOrdersTitle.TabIndex = 1;
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            // 
            // accentOrders
            // 
            this.accentOrders.BackColor = System.Drawing.Color.FromArgb(60, 110, 190);
            this.accentOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentOrders.Size = new System.Drawing.Size(6, 0);
            this.accentOrders.TabIndex = 2;
            this.accentOrders.Name = "accentOrders";
            // 
            // cardLow
            // 
            this.cardLow.BackColor = System.Drawing.Color.White;
            this.cardLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardLow.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardLow.TabIndex = 2;
            this.cardLow.Name = "cardLow";
            this.cardLow.Controls.Add(this.lblLowValue);
            this.cardLow.Controls.Add(this.lblLowTitle);
            this.cardLow.Controls.Add(this.accentLow);
            // 
            // lblLowValue
            // 
            this.lblLowValue.Text = "-";
            this.lblLowValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowValue.ForeColor = System.Drawing.Color.FromArgb(230, 126, 20);
            this.lblLowValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLowValue.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblLowValue.TabIndex = 0;
            this.lblLowValue.Name = "lblLowValue";
            // 
            // lblLowTitle
            // 
            this.lblLowTitle.Text = "Low-stock products";
            this.lblLowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLowTitle.AutoSize = false;
            this.lblLowTitle.Size = new System.Drawing.Size(0, 34);
            this.lblLowTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblLowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLowTitle.Padding = new System.Windows.Forms.Padding(14, 8, 0, 0);
            this.lblLowTitle.TabIndex = 1;
            this.lblLowTitle.Name = "lblLowTitle";
            // 
            // accentLow
            // 
            this.accentLow.BackColor = System.Drawing.Color.FromArgb(230, 126, 20);
            this.accentLow.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentLow.Size = new System.Drawing.Size(6, 0);
            this.accentLow.TabIndex = 2;
            this.accentLow.Name = "accentLow";
            // 
            // cardActive
            // 
            this.cardActive.BackColor = System.Drawing.Color.White;
            this.cardActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActive.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardActive.TabIndex = 3;
            this.cardActive.Name = "cardActive";
            this.cardActive.Controls.Add(this.lblActiveValue);
            this.cardActive.Controls.Add(this.lblActiveTitle);
            this.cardActive.Controls.Add(this.accentActive);
            // 
            // lblActiveValue
            // 
            this.lblActiveValue.Text = "-";
            this.lblActiveValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveValue.ForeColor = System.Drawing.Color.FromArgb(110, 90, 200);
            this.lblActiveValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActiveValue.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblActiveValue.TabIndex = 0;
            this.lblActiveValue.Name = "lblActiveValue";
            // 
            // lblActiveTitle
            // 
            this.lblActiveTitle.Text = "Active products";
            this.lblActiveTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActiveTitle.AutoSize = false;
            this.lblActiveTitle.Size = new System.Drawing.Size(0, 34);
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblActiveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActiveTitle.Padding = new System.Windows.Forms.Padding(14, 8, 0, 0);
            this.lblActiveTitle.TabIndex = 1;
            this.lblActiveTitle.Name = "lblActiveTitle";
            // 
            // accentActive
            // 
            this.accentActive.BackColor = System.Drawing.Color.FromArgb(110, 90, 200);
            this.accentActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentActive.Size = new System.Drawing.Size(6, 0);
            this.accentActive.TabIndex = 2;
            this.accentActive.Name = "accentActive";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.Size = new System.Drawing.Size(0, 28);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(0, 46);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 58, 120);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Name = "lblTitle";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.Size = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.groupLow);
            this.Controls.Add(this.spacer);
            this.Controls.Add(this.tableCards);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTitle);
            this.Load += new System.EventHandler(this.DashboardView_Load);

            ((System.ComponentModel.ISupportInitialize)(this.gridLow)).EndInit();
            this.cardActive.ResumeLayout(false);
            this.cardActive.PerformLayout();
            this.cardLow.ResumeLayout(false);
            this.cardLow.PerformLayout();
            this.cardOrders.ResumeLayout(false);
            this.cardOrders.PerformLayout();
            this.cardSales.ResumeLayout(false);
            this.cardSales.PerformLayout();
            this.tableCards.ResumeLayout(false);
            this.tableCards.PerformLayout();
            this.groupLow.ResumeLayout(false);
            this.groupLow.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupLow;
        private System.Windows.Forms.DataGridView gridLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReorder;
        private System.Windows.Forms.Panel spacer;
        private System.Windows.Forms.TableLayoutPanel tableCards;
        private System.Windows.Forms.Panel cardSales;
        private System.Windows.Forms.Label lblSalesValue;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Panel accentSales;
        private System.Windows.Forms.Panel cardOrders;
        private System.Windows.Forms.Label lblOrdersValue;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Panel accentOrders;
        private System.Windows.Forms.Panel cardLow;
        private System.Windows.Forms.Label lblLowValue;
        private System.Windows.Forms.Label lblLowTitle;
        private System.Windows.Forms.Panel accentLow;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Label lblActiveValue;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Panel accentActive;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTitle;
    }
}

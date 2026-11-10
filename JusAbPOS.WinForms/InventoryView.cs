using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    /// <summary>Inventory Management: list / search + Create, Read, Update, Delete. Layout: InventoryView.Designer.cs</summary>
    public partial class InventoryView : UserControl, IRefreshable
    {
        private readonly User user;
        private readonly InventoryService service;
        private int? selectAfterLoad;

        public InventoryView()
        {
            InitializeComponent();
        }

        public InventoryView(User signedInUser) : this()
        {
            user = signedInUser;
            service = new InventoryService(user);
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            if (service == null) return;           // design-time
            UpdateButtons();
            LoadRows();
        }

        public void RefreshData() { LoadRows(); }

        private Product Selected()
        {
            return gridProducts.CurrentRow == null ? null : gridProducts.CurrentRow.DataBoundItem as Product;
        }

        private void UpdateButtons()
        {
            var has = Selected() != null;
            btnEdit.Enabled = btnDelete.Enabled = btnAdjust.Enabled = has;
        }

        // ------------------------------------------------------------ READ
        private void LoadRows()
        {
            try
            {
                var keepId = selectAfterLoad ?? (Selected() != null ? (int?)Selected().Id : null);
                selectAfterLoad = null;

                var rows = service.Search(txtSearch.Text.Trim(), chkInactive.Checked);
                gridProducts.DataSource = new BindingList<Product>(rows);

                if (keepId.HasValue)
                    foreach (DataGridViewRow row in gridProducts.Rows)
                        if (((Product)row.DataBoundItem).Id == keepId.Value)
                        {
                            row.Selected = true;
                            gridProducts.CurrentCell = row.Cells[1];
                            break;
                        }

                var low = rows.Count(x => x.IsActive && x.IsLowStock);
                lblSummary.Text = rows.Count + " product(s)   |   " + low + " low stock   (low-stock rows are highlighted, inactive rows are grey)";
                UpdateButtons();
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Inventory"); }
        }

        private void gridProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gridProducts.Rows)
            {
                var p = row.DataBoundItem as Product;
                if (p == null) continue;
                if (!p.IsActive) row.DefaultCellStyle.ForeColor = Color.Gray;
                else if (p.IsLowStock) row.DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }

        private void gridProducts_SelectionChanged(object sender, EventArgs e) { UpdateButtons(); }
        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex >= 0) EditSelected(); }

        private void gridProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;
            e.Handled = true;
            DeleteSelected();
        }

        private void btnSearch_Click(object sender, EventArgs e) { LoadRows(); }
        private void chkInactive_CheckedChanged(object sender, EventArgs e) { LoadRows(); }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            LoadRows();
        }

        // ------------------------------------------------------------ CREATE
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editor = new ProductEditorForm(user, null))
                if (editor.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    selectAfterLoad = editor.SavedProductId;
                    LoadRows();
                }
        }

        // ------------------------------------------------------------ UPDATE
        private void btnEdit_Click(object sender, EventArgs e) { EditSelected(); }

        private void EditSelected()
        {
            var p = Selected();
            if (p == null) return;
            using (var editor = new ProductEditorForm(user, p.Id))
                if (editor.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    selectAfterLoad = p.Id;
                    LoadRows();
                }
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            var p = Selected();
            if (p == null) return;
            using (var dialog = new StockAdjustForm(user, p))
                if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    selectAfterLoad = p.Id;
                    LoadRows();
                }
        }

        // ------------------------------------------------------------ DELETE (soft)
        private void btnDelete_Click(object sender, EventArgs e) { DeleteSelected(); }

        private void DeleteSelected()
        {
            var p = Selected();
            if (p == null) return;
            if (!p.IsActive)
            {
                MessageBox.Show("'" + p.Name + "' is already inactive. Use Edit to reactivate it.", "Delete product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var answer = MessageBox.Show(
                "Delete '" + p.Name + "' (" + p.Sku + ")?\n\nThe product is deactivated and hidden from the list, " +
                "but its sales history is kept. You can restore it later from 'Show inactive' > Edit.",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer != DialogResult.Yes) return;

            try
            {
                service.Delete(p.Id);
                LoadRows();
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Delete product"); }
        }
    }
}

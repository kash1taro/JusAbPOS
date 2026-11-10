using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    /// <summary>Add / Edit product. productId == null means "new product". Layout: ProductEditorForm.Designer.cs</summary>
    public partial class ProductEditorForm : Form
    {
        private readonly InventoryService service;
        private readonly int? productId;
        private byte[] imageBytes;
        private bool imageChanged;

        /// <summary>The id of the product that was saved (valid when DialogResult is OK).</summary>
        public int SavedProductId { get; private set; }

        public ProductEditorForm()
        {
            InitializeComponent();
        }

        public ProductEditorForm(User user, int? id) : this()
        {
            service = new InventoryService(user);
            productId = id;
            Text = id.HasValue ? "Edit Product" : "Add Product";
            chkActive.Visible = id.HasValue;
            if (id.HasValue)
            {
                numStock.Enabled = false;                 // stock changes go through 'Adjust Stock' so they are always logged
                lblStock.Text = "Stock (read-only)";
            }
        }

        private void ProductEditorForm_Load(object sender, EventArgs e)
        {
            if (service == null) return;                  // design-time
            try
            {
                cboCategory.DisplayMember = "Name";
                cboCategory.ValueMember = "Id";
                cboCategory.DataSource = service.GetCategories();

                if (!productId.HasValue) return;

                var p = service.GetById(productId.Value);
                if (p == null) throw new InvalidOperationException("That product no longer exists.");
                txtSku.Text = p.Sku;
                txtBarcode.Text = p.Barcode;
                txtName.Text = p.Name;
                cboCategory.SelectedValue = p.CategoryId;
                numPrice.Value = p.Price;
                numCost.Value = p.Cost;
                numStock.Value = p.StockQty;
                numReorder.Value = p.ReorderLevel;
                chkActive.Checked = p.IsActive;
                imageBytes = p.Image;
                ShowImage(p.Image);
            }
            catch (Exception ex)
            {
                UiHelper.ShowError(ex, "Product");
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png", CheckFileExists = true })
            {
                if (dialog.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    if (new FileInfo(dialog.FileName).Length > InventoryService.MaxImageBytes)
                        throw new ArgumentException("The image must be 2 MB or smaller.");
                    var bytes = File.ReadAllBytes(dialog.FileName);
                    ShowImage(bytes);                // throws if the file is not a real image
                    imageBytes = bytes;
                    imageChanged = true;
                }
                catch (ArgumentException ex) { UiHelper.Warn(ex.Message, "Image"); }
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            imageBytes = null;
            imageChanged = true;
            ShowImage(null);
        }

        private void ShowImage(byte[] bytes)
        {
            if (picture.Image != null) { picture.Image.Dispose(); picture.Image = null; }
            if (bytes == null || bytes.Length == 0) return;
            try
            {
                using (var ms = new MemoryStream(bytes))
                using (var img = Image.FromStream(ms))
                    picture.Image = new Bitmap(img);
            }
            catch (Exception) { throw new ArgumentException("That file is not a valid image."); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Product
                {
                    Id = productId ?? 0,
                    Sku = txtSku.Text,
                    Barcode = txtBarcode.Text,
                    Name = txtName.Text,
                    CategoryId = cboCategory.SelectedValue is int ? (int)cboCategory.SelectedValue : 0,
                    Price = numPrice.Value,
                    Cost = numCost.Value,
                    StockQty = (int)numStock.Value,
                    ReorderLevel = (int)numReorder.Value,
                    IsActive = productId.HasValue ? chkActive.Checked : true,
                    Image = imageBytes
                };

                if (productId.HasValue) { service.Update(p, imageChanged); SavedProductId = p.Id; }
                else SavedProductId = service.Create(p);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { UiHelper.ShowError(ex, "Product"); }   // stays open so the value can be corrected
        }
    }
}

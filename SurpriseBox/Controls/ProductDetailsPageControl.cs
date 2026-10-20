using SurpriseBox.Models;

namespace SurpriseBox.Controls
{
    public partial class ProductDetailsPageControl : UserControl
    {
        // Catalog item displayed on the details page
        private CatalogItem _item;

        /// <summary>
        /// Initializes the product details page and loads product information.
        /// </summary>
        /// <param name="item">Catalog item to display.</param>
        public ProductDetailsPageControl(CatalogItem item)
        {
            InitializeComponent();
            _item = item;
            FillData();
        }

        /// <summary>
        /// Fills the details page with product information.
        /// </summary>
        private void FillData()
        {
            // pbProductImage.Image = Image.FromFile(_item.LargeImagePath);    // Small product image
            lblCategory.Text = _item.CatalogCategory.ToString();    // Product category
            lblName.Text = _item.Name;
            lblDescription.Text = _item.Description;

            // Gift and Experience display different labels depending on the context.
            switch (_item.CatalogCategory.ToString())
            {
                case "Gift":
                    {
                        lblDescriptionTitle.Text = "About gift";
                        lblExtraInfo.Text = "1 hours";
                        break;
                    }
                case "Experience":
                    {
                        lblDescriptionTitle.Text = "About experience";
                        lblExtraInfo.Text = "1 pcs.";
                        break;
                    }
            }
        }

        /// <summary>
        /// Decreases the selected quantity by one.
        /// </summary>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblQuantity.Text, out int quantity) && quantity > 1)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
            }
        }

        /// <summary>
        /// Increases the selected quantity by one.
        /// </summary>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblQuantity.Text, out int quantity))
            {
                quantity++;
                lblQuantity.Text = quantity.ToString();
            }
        }
    }
}
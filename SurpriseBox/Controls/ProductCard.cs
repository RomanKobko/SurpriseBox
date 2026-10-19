using SurpriseBox.Models;

namespace SurpriseBox.Controls
{
    /// <summary>
    /// Catalog product card control.
    /// Used to display brief information about a product or service.
    /// </summary>
    public partial class ProductCard : UserControl
    {
        // Catalog item whose data is displayed in the card
        private CatalogItem _item;

        /// <summary>
        /// Initializes the card and fills it with data.
        /// </summary>
        /// <param name="item">Catalog item to display.</param>
        public ProductCard(CatalogItem item)
        {
            InitializeComponent();
            _item = item;
            FillData();
        }

        /// <summary>
        /// Fills the interface elements with product data.
        /// </summary>
        private void FillData()
        {
            lblCategory.Text = _item.CatalogCategory.ToString();    // Product category
            pbImage.Image = Image.FromFile(_item.SmallImagePath);    // Small product image
            lblName.Text = _item.Name;    // Product name
            lblDescription.Text = _item.Description;    // Product description
            lblPrice.Text = $"{_item.Price:N0} Hearts";    // Product price
        }
    }
}
using SurpriseBox.Models;
using SurpriseBox.Models.Enums;
using SurpriseBox.Service;
using SurpriseBox.Service.Interfaces;

namespace SurpriseBox.Controls
{
    /// <summary>
    /// Product details page control.
    /// Displays detailed information about a selected catalog item
    /// and allows the user to add the item to the shopping cart.
    /// </summary>
    public partial class ProductDetailsPageControl : UserControl
    {
        // Catalog item displayed on the details page
        private readonly CatalogItem _item;
        // Service responsible for shopping cart operations
        private readonly ICartService _cartService;

        /// <summary>
        /// Initializes the product details page and loads product information.
        /// </summary>
        /// <param name="item">
        /// Catalog item to display.
        /// </param>
        public ProductDetailsPageControl(CatalogItem item)
        {
            InitializeComponent();
            _item = item;
            _cartService = new CartService();
            FillData();
        }

        /// <summary>
        /// Fills all user interface elements with the selected product information.
        /// </summary>
        private void FillData()
        {
            // Display the product category
            lblCategory.Text = _item.CatalogCategory.ToString();

            // Display the product name and description
            lblName.Text = _item.Name;
            lblDescription.Text = _item.Description;

            // Build the full path to the product image
            string largeImagePath = Path.Combine(
                Application.StartupPath,
                "images",
                _item.LargeImagePath);

            // Load the product image if the file exists
            if (File.Exists(largeImagePath))
            {
                pbProductImage.Image = Image.FromFile(largeImagePath);
            }

            // Configure additional information based on the catalog category
            switch (_item.CatalogCategory)
            {
                case CatalogCategory.Gift:
                    {
                        lblDescriptionTitle.Text = "About gift";
                        lblExtraInfo.Text = "1 pcs.";
                        break;
                    }
                case CatalogCategory.Experience:
                    {
                        lblDescriptionTitle.Text = "About experience";
                        lblExtraInfo.Text = "1 hours";
                        break;
                    }
            }
        }

        /// <summary>
        /// Decreases the selected quantity by one.
        /// The quantity cannot be less than one.
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

        /// <summary>
        /// Creates a cart item from the currently selected catalog item
        /// and adds it to the shopping cart.
        /// </summary>
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            CartItem cartItem = new CartItem(_item);

            _cartService.AddCartItems(cartItem);
        }
    }
}
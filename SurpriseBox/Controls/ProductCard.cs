using SurpriseBox.Models;
using SurpriseBox.Service;
using SurpriseBox.Service.Interfaces;

namespace SurpriseBox.Controls
{
    /// <summary>
    /// Catalog product card control.
    /// Used to display brief information about a product or service.
    /// </summary>
    public partial class ProductCard : UserControl
    {
        // Catalog item displayed by this card
        private readonly CatalogItem _item;
        // Service responsible for shopping cart operations
        private readonly ICartService _cartService;

        // Raised when the user selects the product card
        public event Action<CatalogItem>? ProductSelected;

        /// <summary>
        /// Initializes the product card and fills it with catalog item data.
        /// </summary>
        /// <param name="item">
        /// The catalog item to be displayed by the card.
        /// </param>
        public ProductCard(CatalogItem item)
        {
            InitializeComponent();

            _cartService = new CartService();
            _item = item;

            FillData();

            // Open the product details page when the name or image is clicked
            lblName.Click += OpenProduct;
            pbImage.Click += OpenProduct;
        }

        /// <summary>
        /// Populates all user interface elements with catalog item information.
        /// </summary>
        private void FillData()
        {
            // Display the product category
            lblCategory.Text = _item.CatalogCategory.ToString();

            // Build the full path to the product image
            string smallImagePath = Path.Combine(
                Application.StartupPath,
                "images",
                _item.SmallImagePath);

            // Load the image if the file exists
            if (File.Exists(smallImagePath))
            {
                pbImage.Image = Image.FromFile(smallImagePath);
            }

            // Display basic product information
            lblName.Text = _item.Name;
            lblDescription.Text = _item.Description;
            lblPrice.Text = $"{_item.Price:N0} Hearts";
        }

        /// <summary>
        /// Raises the ProductSelected event and passes the selected catalog item
        /// to subscribers so that the corresponding product details page can be opened.
        /// </summary>
        private void OpenProduct(object? sender, EventArgs e)
        {
            ProductSelected?.Invoke(_item);
        }

        /// <summary>
        /// Creates a shopping cart item based on the current catalog item
        /// and adds it to the shopping cart.
        /// </summary>
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            CartItem cartItem = new CartItem(_item);

            _cartService.AddCartItems(cartItem);
        }
    }
}
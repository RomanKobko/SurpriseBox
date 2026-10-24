using SurpriseBox.Models;
using SurpriseBox.Models.Enums;
using SurpriseBox.Service;
using SurpriseBox.Service.Interfaces;

namespace SurpriseBox.Controls
{
    /// <summary>
    /// Shopping cart item card control.
    /// Used to display product information and manage item quantity within the shopping cart.
    /// </summary>
    public partial class CartItemCard : UserControl
    {
        // Service responsible for shopping cart operations
        private readonly ICartService _cartService;
        // Shopping cart item represented by this card
        private readonly CartItem _item;
        // Currently selected quantity displayed on the card
        private int _currentQuantity;

        // Raised when the item quantity changes
        public event Action? OnQuantityChanged;
        // Raised when the item is removed from the shopping cart
        public event Action? OnButtonDeleteClicked;

        /// <summary>
        /// Initializes the shopping cart item card and populates it with data.
        /// </summary>
        /// <param name="item">The shopping cart item to display.</param>
        public CartItemCard(CartItem item)
        {
            InitializeComponent();

            _cartService = new CartService();
            _item = item;
            _currentQuantity = item.Quantity;

            FillData();
        }

        /// <summary>
        /// Fills all user interface elements with shopping cart item data.
        /// </summary>
        private void FillData()
        {
            // Display the product category
            lblCategory.Text = _item.CatalogItem.CatalogCategory.ToString();

            // Build the full path to the product image
            string smallImagePath = Path.Combine(Application.StartupPath, "images", _item.CatalogItem.SmallImagePath);

            // Load the product image if the file exists
            if (File.Exists(smallImagePath))
            {
                pbProductImage.Image = Image.FromFile(smallImagePath);
            }

            // Display product information
            lblName.Text = _item.CatalogItem.Name;
            lblDescription.Text = _item.CatalogItem.Description;

            // Display quantity and pricing information
            lblQuantity.Text = _item.Quantity.ToString();
            lblUnitPrice.Text = $"{_item.CatalogItem.Price} Hearts";
            lblTotalPrice.Text = $"{_item.CatalogItem.Price * _item.Quantity} Hearts";

            // Display additional information depending on product category
            switch (_item.CatalogItem.CatalogCategory)
            {
                case CatalogCategory.Gift:
                    lblExtraInfo.Text = $"{lblQuantity.Text} pcs";
                    break;

                case CatalogCategory.Experience:
                    lblExtraInfo.Text = $"{lblQuantity.Text} hours";
                    break;
            }
        }

        /// <summary>
        /// Decreases the quantity of the current cart item by one.
        /// Updates the displayed price and notifies subscribers about the change.
        /// </summary>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_currentQuantity > 1)
            {
                _currentQuantity--;

                lblQuantity.Text = _currentQuantity.ToString();
                lblTotalPrice.Text =
                    $"{_item.CatalogItem.Price * _currentQuantity} Hearts";

                _cartService.DecreaseItemQuantity(_item);

                OnQuantityChanged?.Invoke();
            }
        }

        /// <summary>
        /// Increases the quantity of the current cart item by one.
        /// Updates the displayed price and notifies subscribers about the change.
        /// </summary>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            _currentQuantity++;

            lblQuantity.Text = _currentQuantity.ToString();
            lblTotalPrice.Text =
                $"{_item.CatalogItem.Price * _currentQuantity} Hearts";

            _cartService.AddCartItems(_item);

            OnQuantityChanged?.Invoke();
        }

        /// <summary>
        /// Removes the current item from the shopping cart
        /// and notifies subscribers about the deletion.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _cartService.RemoveCartItems(_item);

            OnButtonDeleteClicked?.Invoke();
        }
    }
}
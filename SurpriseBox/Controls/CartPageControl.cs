using SurpriseBox.Models;
using SurpriseBox.Models.Enums;
using SurpriseBox.Service;
using SurpriseBox.Service.Interfaces;

namespace SurpriseBox.Controls
{
    /// <summary>
    /// Shopping cart page control.
    /// Responsible for displaying cart items, managing cart navigation,
    /// and showing order summary information.
    /// </summary>
    public partial class CartPageControl : UserControl
    {
        // Maximum number of cart items displayed at the same time
        private const int _maxItemsPerPage = 3;
        // Current cart page
        private int _currentPage = 1;
        // Last available cart page
        private int _lastPage = 1;
        // Service responsible for shopping cart operations
        private readonly ICartService _cartService;
        // Collection of cart items currently displayed in the cart
        private List<CartItem> _cartItems = new List<CartItem>();

        /// <summary>
        /// Raised when the shopping cart is cleared.
        /// </summary>
        public event Action? OnButtonCleanCart_Click;

        /// <summary>
        /// Initializes the shopping cart page and loads cart data.
        /// </summary>
        public CartPageControl()
        {
            OnButtonCleanCart_Click += LoadOrderSummaryInformation;
            OnButtonCleanCart_Click += LoadCatalog;

            InitializeComponent();

            _cartService = new CartService();

            LoadCatalog();
            LoadOrderSummaryInformation();
        }

        /// <summary>
        /// Loads cart items for the current page and displays them.
        /// </summary>
        private void LoadCatalog()
        {
            _cartItems = _cartService.LoadCartItems();

            // Remove currently displayed cart item cards
            flpCartItems.Controls.Clear();

            // Calculate the last available page for sliding navigation
            _lastPage = _cartItems.Count - 2;

            // Calculate the index of the first item displayed on the current page
            int numberOfItem = _currentPage - 1;

            // Create and display cart item cards
            for (int i = numberOfItem;
                 (i < numberOfItem + _maxItemsPerPage) &&
                 (i < _cartItems.Count);
                 i++)
            {
                CartItemCard card = new CartItemCard(_cartItems[i]);

                // Refresh the cart when an item is removed
                card.OnButtonDeleteClicked += LoadCatalog;
                card.OnButtonDeleteClicked += LoadOrderSummaryInformation;

                // Refresh summary information when item quantity changes
                card.OnQuantityChanged += LoadOrderSummaryInformation;

                flpCartItems.Controls.Add(card);
            }
        }

        /// <summary>
        /// Calculates and displays order summary information,
        /// including item counts and total cart price.
        /// </summary>
        private void LoadOrderSummaryInformation()
        {
            int countOfGift = 0;
            int countOfExperience = 0;
            decimal totalPrice = 0;

            _cartItems = _cartService.LoadCartItems();

            foreach (var item in _cartItems)
            {
                switch (item.CatalogItem.CatalogCategory)
                {
                    case CatalogCategory.Gift:
                        {
                            countOfGift += item.Quantity;
                            break;
                        }
                    case CatalogCategory.Experience:
                        {
                            countOfExperience += item.Quantity;
                            break;
                        }
                }

                // Calculate the total cart price
                totalPrice += item.CatalogItem.Price * item.Quantity;
            }

            // Update summary information labels
            lblGiftCount.Text = $"Gifts: {countOfGift}";
            lblExperienceCount.Text = $"Experience: {countOfExperience} hours";
            lblTotalPrice.Text = $"{totalPrice:N0} Hearts";
        }

        /// <summary>
        /// Navigates to the previous cart page.
        /// </summary>
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;

                LoadCatalog();
            }
        }

        /// <summary>
        /// Navigates to the next cart page.
        /// </summary>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _lastPage)
            {
                _currentPage++;

                LoadCatalog();
            }
        }

        /// <summary>
        /// Removes all items from the shopping cart
        /// and refreshes the displayed information.
        /// </summary>
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _cartService.RemoveAllCartItems();

            OnButtonCleanCart_Click?.Invoke();
        }
    }
}
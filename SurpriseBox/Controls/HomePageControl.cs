using SurpriseBox.Models;
using SurpriseBox.Service;
using SurpriseBox.Service.Interfaces;

namespace SurpriseBox.Controls
{
    /// <summary>
    /// Main page control of the catalog.
    /// Responsible for displaying products and navigating between pages.
    /// </summary>
    public partial class HomePageControl : UserControl
    {
        // Maximum number of items per page
        private int maxItemsPerPage = 6;
        // Current catalog page
        private int _currentPage = 1;
        // Last available page
        private int _lastPage = 1;
        // Service for loading catalog data
        private readonly ICatalogService _catalogService;
        // Products currently displayed in the catalog
        private List<CatalogItem> _catalogItems;

        // Event triggered when the user selects a product card
        public event Action<CatalogItem>? ProductSelected;

        /// <summary>
        /// Gets text that displays the status of pages on the product page
        /// </summary>
        public string LblPageInfo
        {
            get
            {
                return lblPageInfo.Text;
            }
        }

        /// <summary>
        /// Indicates whether a search query has been entered.
        /// </summary>
        public bool IsSearchActive
        {
            get
            {
                return !string.IsNullOrWhiteSpace(txtSearch.Text);
            }
        }

        /// <summary>
        /// Initializes an instance of the main page and loads the catalog.
        /// </summary>
        public HomePageControl()
        {
            InitializeComponent();

            _catalogService = new CatalogService();

            // Initial catalog loading
            _catalogItems = _catalogService.LoadCatalogItems();

            LoadCatalog();
        }

        /// <summary>
        /// Loads products for the current page and displays them in the catalog.
        /// </summary>
        private void LoadCatalog()
        {
            // Clearing current cards
            flpProducts.Controls.Clear();

            // Pagination calculations and UI update
            _lastPage = (_catalogItems.Count + maxItemsPerPage - 1) / maxItemsPerPage;  // Calculating the total number of pages
            int numberOfItem = ((_currentPage - 1) * maxItemsPerPage);  // Index of the first item on the current page
            lblPageInfo.Text = $"{_currentPage} з {_lastPage}"; // Updating page information

            // Creating and adding product cards
            for (int i = numberOfItem; (i < numberOfItem + maxItemsPerPage) && (i < _catalogItems.Count); i++)
            {
                ProductCard card = new ProductCard(_catalogItems[i]);
                flpProducts.Controls.Add(card);
                card.ProductSelected += OpenProductDetails;
            }
        }

        /// <summary>
        /// Navigates to the previous catalog page.
        /// </summary>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Navigation is possible only if it is not the first page
            if (_currentPage > 1)
            {
                _currentPage--;
                lblPageInfo.Text = $"{_currentPage} з {_lastPage}";
                LoadCatalog();
            }
        }

        /// <summary>
        /// Navigates to the next catalog page.
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Navigation is possible only if it is not the last page
            if (_currentPage < _lastPage)
            {
                _currentPage++;
                lblPageInfo.Text = $"{_currentPage} з {_lastPage}";
                LoadCatalog();
            }
        }

        /// <summary>
        /// Raises the ProductSelected event when a product card is opened.
        /// </summary>
        /// <param name="item">The selected catalog item.</param>
        private void OpenProductDetails(CatalogItem item)
        {
            ProductSelected?.Invoke(item);
        }

        /// <summary>
        /// Searches catalog items by product name and refreshes the displayed catalog.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // If the search field is empty, restore the full catalog
            if (string.IsNullOrEmpty(searchText))
            {
                _catalogItems = _catalogService.LoadCatalogItems();
            }
            else    // Filter catalog items whose name contains the search text
            {
                _catalogItems = (from item in _catalogService.LoadCatalogItems()
                                 where item.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                                 select item).ToList();
            }

            _currentPage = 1;    // Reset pagination to the first page
            LoadCatalog();    // Refresh the catalog view
        }
    }
}
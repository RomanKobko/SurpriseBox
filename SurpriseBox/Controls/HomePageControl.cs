using SurpriseBox.Models;
using SurpriseBox.Service;
using SurpriseBox.Service.Interfaces;

namespace SurpriseBox.Controls
{
    /// <summary>
    /// Main page control of the catalog.
    /// Responsible for displaying catalog items, handling search,
    /// and navigating between catalog pages.
    /// </summary>
    public partial class HomePageControl : UserControl
    {
        // Maximum number of catalog items displayed on a single page
        private const int _maxItemsPerPage = 6;
        // Service responsible for loading catalog data
        private readonly ICatalogService _catalogService;
        // Currently displayed catalog page
        private int _currentPage = 1;
        // Last available catalog page
        private int _lastPage = 1;
        // Collection of catalog items currently displayed in the catalog
        private List<CatalogItem> _catalogItems;

        /// <summary>
        /// Raised when the user selects a product card.
        /// </summary>
        public event Action<CatalogItem>? ProductSelected;

        /// <summary>
        /// Gets the current catalog page information text.
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

            // Load the complete catalog during initialization
            _catalogItems = _catalogService.LoadCatalogItems();

            LoadCatalog();
        }

        /// <summary>
        /// Loads products for the current page and displays them in the catalog.
        /// </summary>
        private void LoadCatalog()
        {
            // Remove currently displayed product cards
            flpProducts.Controls.Clear();

            // Calculate pagination information
            _lastPage = (_catalogItems.Count + _maxItemsPerPage - 1) / _maxItemsPerPage;

            // Calculate the index of the first item on the current page
            int numberOfItem = (_currentPage - 1) * _maxItemsPerPage;

            // Update page information label
            lblPageInfo.Text = $"{_currentPage} з {_lastPage}";

            // Create and display product cards for the current page
            for (int i = numberOfItem;
                 (i < numberOfItem + _maxItemsPerPage) &&
                 (i < _catalogItems.Count);
                 i++)
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
            // Navigation is possible only if the current page is not the first page
            if (_currentPage > 1)
            {
                _currentPage--;

                LoadCatalog();
            }
        }

        /// <summary>
        /// Navigates to the next catalog page.
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Navigation is possible only if the current page is not the last page
            if (_currentPage < _lastPage)
            {
                _currentPage++;

                LoadCatalog();
            }
        }

        /// <summary>
        /// Raises the ProductSelected event and passes
        /// the selected catalog item to subscribers.
        /// </summary>
        /// <param name="item">
        /// The selected catalog item.
        /// </param>
        private void OpenProductDetails(CatalogItem item)
        {
            ProductSelected?.Invoke(item);
        }

        /// <summary>
        /// Searches catalog items by name and refreshes the displayed catalog.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // Restore the full catalog if the search field is empty
            if (string.IsNullOrEmpty(searchText))
            {
                _catalogItems = _catalogService.LoadCatalogItems();
            }
            else
            {
                // Filter catalog items whose names contain the search text
                _catalogItems =
                    (from item in _catalogService.LoadCatalogItems()
                     where item.Name.Contains(
                         searchText,
                         StringComparison.OrdinalIgnoreCase)
                     select item).ToList();
            }

            // Reset pagination to the first page
            _currentPage = 1;

            // Refresh the catalog view
            LoadCatalog();
        }
    }
}
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

        /// <summary>
        /// Initializes an instance of the main page and loads the catalog.
        /// </summary>
        public HomePageControl()
        {
            InitializeComponent();
            _catalogService = new CatalogService();
            LoadCatalog();
        }

        /// <summary>
        /// Loads products for the current page and displays them in the catalog.
        /// </summary>
        private void LoadCatalog()
        {
            // Clearing current cards
            flpProducts.Controls.Clear();

            // Retrieving all products from the service
            List<CatalogItem> availableItem = _catalogService.LoadCatalogItems();

            // Pagination calculations and UI update
            _lastPage = (availableItem.Count + maxItemsPerPage - 1) / maxItemsPerPage;  // Calculating the total number of pages
            int numberOfItem = ((_currentPage - 1) * maxItemsPerPage);  // Index of the first item on the current page
            lblPageInfo.Text = $"{_currentPage} з {_lastPage}"; // Updating page information

            // Creating and adding product cards
            for (int i = numberOfItem; (i < numberOfItem + maxItemsPerPage) && (i < availableItem.Count); i++)
            {
                ProductCard card = new ProductCard(availableItem[i]);
                flpProducts.Controls.Add(card);
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
                _currentPage = _currentPage - 1;
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
                _currentPage = _currentPage + 1;
                lblPageInfo.Text = $"{_currentPage} з {_lastPage}";
                LoadCatalog();
            }
        }
    }
}
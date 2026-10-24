using SurpriseBox.Controls;
using SurpriseBox.Models;

namespace SurpriseBox.Forms
{
    /// <summary>
    /// Main application form.
    /// Responsible for hosting page controls and handling navigation
    /// between different sections of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes the main application form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // LoadCartPage();
            LoadHomePage();

            // Save screen coordinates while the label is still positioned relative to the form
            Point titleScreenPos = this.PointToScreen(lblBannerTitle.Location);

            // Set the banner image as the parent container of the label
            lblBannerTitle.Parent = pbBanner;

            // Convert the saved screen coordinates to client coordinates of the banner image
            lblBannerTitle.Location = pbBanner.PointToClient(titleScreenPos);

            // Enable transparency so the label is rendered over the banner image
            lblBannerTitle.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Loads the home page into the main content panel.
        /// </summary>
        private void LoadHomePage()
        {
            // Remove the currently displayed page
            pnlContent.Controls.Clear();

            // Create the home page
            HomePageControl homePage = new HomePageControl();

            // Subscribe to product selection events
            homePage.ProductSelected += LoadProductDetailsPage;

            // Display the page
            pnlContent.Controls.Add(homePage);
        }

        /// <summary>
        /// Loads the product details page for the selected catalog item.
        /// </summary>
        /// <param name="item">
        /// The selected catalog item.
        /// </param>
        private void LoadProductDetailsPage(CatalogItem item)
        {
            // Remove the currently displayed page
            pnlContent.Controls.Clear();

            // Create the product details page
            ProductDetailsPageControl productDetailsPage = new ProductDetailsPageControl(item);

            // Display the page
            pnlContent.Controls.Add(productDetailsPage);
        }

        /// <summary>
        /// Loads the shopping cart page into the main content panel.
        /// </summary>
        private void LoadCartPage()
        {
            // Remove the currently displayed page
            pnlContent.Controls.Clear();

            // Create the shopping cart page
            CartPageControl cartPage = new CartPageControl();

            // Display the page
            pnlContent.Controls.Add(cartPage);
        }

        /// <summary>
        /// Handles navigation to the home page. Reloads the page if a search is active or the user is not currently on the first catalog page.
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            // If the current page is not the home page, navigate directly to the home page
            if (pnlContent.Controls[0] is not HomePageControl homePage)
            {
                LoadHomePage();
                return;
            }

            // Reload the home page when search results are displayed or when the user is not on the first catalog page
            if (homePage.IsSearchActive || homePage.LblPageInfo[0] != '1')
            {
                LoadHomePage();
            }
        }

        /// <summary>
        /// Handles navigation to the shopping cart page. Prevents reloading the page if the cart page is already displayed.
        /// </summary>
        private void btnCart_Click(object sender, EventArgs e)
        {
            // Load the cart page only when another page is currently displayed
            if (pnlContent.Controls[0] is not CartPageControl)
            {
                LoadCartPage();
            }
        }
    }
}
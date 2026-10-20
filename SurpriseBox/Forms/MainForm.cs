using SurpriseBox.Controls;
using SurpriseBox.Models;

namespace SurpriseBox.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes the main application form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LoadHomePage();

            // 1. Save screen coordinates while the labels are still positioned relative to the Form
            Point titleScreenPos = this.PointToScreen(lblBannerTitle.Location);
            Point subtitleScreenPos = this.PointToScreen(lblBannerSubtitle.Location);

            // 2. Set the picture box as the official parent container for the labels
            lblBannerTitle.Parent = pbBanner;
            lblBannerSubtitle.Parent = pbBanner;

            // 3. Convert the saved screen coordinates into the client coordinates of pbBanner
            lblBannerTitle.Location = pbBanner.PointToClient(titleScreenPos);
            lblBannerSubtitle.Location = pbBanner.PointToClient(subtitleScreenPos);

            // 4. Enable transparency so the labels display the background image of the parent container
            lblBannerTitle.BackColor = Color.Transparent;
            lblBannerSubtitle.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Loads the home page into the content panel.
        /// </summary>
        private void LoadHomePage()
        {
            pnlContent.Controls.Clear();

            HomePageControl homePage = new HomePageControl();

            homePage.ProductSelected += LoadProductDetailsPage;

            pnlContent.Controls.Add(homePage);
        }

        /// <summary>
        /// Loads the product details page for the selected catalog item.
        /// </summary>
        /// <param name="item">Selected catalog item.</param>
        private void LoadProductDetailsPage(CatalogItem item)
        {
            pnlContent.Controls.Clear();

            ProductDetailsPageControl homePage = new ProductDetailsPageControl(item);

            pnlContent.Controls.Add(homePage);
        }

        /// <summary>
        /// Handles navigation to the home page.
        /// Reloads the page if a search is active or the user is not on the first catalog page.
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (pnlContent.Controls[0] is not HomePageControl homePage)
            {
                LoadHomePage();
                return;
            }

            if (homePage.IsSearchActive || homePage.LblPageInfo[0] != '1')
            {
                LoadHomePage();
            }
        }
    }
}
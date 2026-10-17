using SurpriseBox.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace SurpriseBox.Forms
{
    public partial class MainForm : Form
    {
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

        private void LoadHomePage()
        {
            pnlContent.Controls.Clear();

            HomePageControl homePage = new HomePageControl();

            homePage.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(homePage);
        }
    }
}

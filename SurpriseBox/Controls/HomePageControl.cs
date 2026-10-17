using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SurpriseBox.Controls
{
    public partial class HomePageControl : UserControl
    {
        public HomePageControl()
        {
            InitializeComponent();
            LoadTestProducts();
        }

        private void LoadTestProducts()
        {
            flpProducts.Controls.Clear();

            for (int i = 0; i < 6; i++)
            {
                ProductCard card = new ProductCard();

                flpProducts.Controls.Add(card);
            }
        }
    }
}

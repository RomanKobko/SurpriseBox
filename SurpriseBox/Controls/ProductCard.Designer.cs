namespace SurpriseBox.Controls
{
    partial class ProductCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbImage = new PictureBox();
            pnlCategory = new FlowLayoutPanel();
            lblCategory = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            pbHeart = new PictureBox();
            lblPrice = new Label();
            btnAddToCart = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeart).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.DefaultProductCardImg;
            pbImage.Location = new Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(498, 120);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // pnlCategory
            // 
            pnlCategory.BackColor = Color.FromArgb(40, 40, 45);
            pnlCategory.Controls.Add(lblCategory);
            pnlCategory.Location = new Point(10, 10);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(100, 35);
            pnlCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.FlatStyle = FlatStyle.Popup;
            lblCategory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(0, 0);
            lblCategory.Margin = new Padding(0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 35);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoEllipsis = true;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Georgia", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 135);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(151, 27);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Service Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoEllipsis = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Gainsboro;
            lblDescription.Location = new Point(11, 165);
            lblDescription.MaximumSize = new Size(339, 45);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(326, 45);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Service short description";
            // 
            // pbHeart
            // 
            pbHeart.Image = Properties.Resources.RedHeart;
            pbHeart.Location = new Point(10, 218);
            pbHeart.Name = "pbHeart";
            pbHeart.Size = new Size(18, 18);
            pbHeart.SizeMode = PictureBoxSizeMode.Zoom;
            pbHeart.TabIndex = 4;
            pbHeart.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(255, 190, 80);
            lblPrice.Location = new Point(35, 215);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(97, 23);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "350 Hearts";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(245, 185, 70);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.Location = new Point(350, 195);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(135, 38);
            btnAddToCart.TabIndex = 6;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 20, 30);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnAddToCart);
            Controls.Add(lblPrice);
            Controls.Add(pbHeart);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(pnlCategory);
            Controls.Add(pbImage);
            Margin = new Padding(5);
            Name = "ProductCard";
            Size = new Size(500, 245);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            pnlCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHeart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private FlowLayoutPanel pnlCategory;
        private Label lblCategory;
        private Label lblTitle;
        private Label lblDescription;
        private PictureBox pbHeart;
        private Label lblPrice;
        private Button btnAddToCart;
    }
}

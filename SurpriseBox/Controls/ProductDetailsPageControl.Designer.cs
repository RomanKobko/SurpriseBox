namespace SurpriseBox.Controls
{
    partial class ProductDetailsPageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsPageControl));
            pbProductImage = new PictureBox();
            pnlInfo = new Panel();
            btnAddToCart = new Button();
            pnlQuantity = new Panel();
            btnPlus = new Button();
            lblQuantity = new Label();
            btnMinus = new Button();
            pnlPriceInfo = new Panel();
            lblSeparator = new Label();
            lblExtraInfo = new Label();
            lblPrice = new Label();
            pbHeart = new PictureBox();
            lblName = new Label();
            pnlCategory = new Panel();
            lblCategory = new Label();
            pnlDescription = new Panel();
            lblDescription = new Label();
            lblDescriptionTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            pnlInfo.SuspendLayout();
            pnlQuantity.SuspendLayout();
            pnlPriceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeart).BeginInit();
            pnlCategory.SuspendLayout();
            pnlDescription.SuspendLayout();
            SuspendLayout();
            // 
            // pbProductImage
            // 
            pbProductImage.BorderStyle = BorderStyle.FixedSingle;
            pbProductImage.Image = Properties.Resources.DefaultProductCardFullImg;
            pbProductImage.Location = new Point(25, 20);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(980, 420);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(10, 15, 25);
            pnlInfo.Controls.Add(btnAddToCart);
            pnlInfo.Controls.Add(pnlQuantity);
            pnlInfo.Controls.Add(pnlPriceInfo);
            pnlInfo.Controls.Add(lblName);
            pnlInfo.Controls.Add(pnlCategory);
            pnlInfo.Location = new Point(1025, 20);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(520, 420);
            pnlInfo.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddToCart.BackColor = Color.FromArgb(242, 192, 75);
            btnAddToCart.Cursor = Cursors.Hand;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.Location = new Point(20, 310);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(480, 50);
            btnAddToCart.TabIndex = 7;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // pnlQuantity
            // 
            pnlQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlQuantity.BackColor = Color.Transparent;
            pnlQuantity.Controls.Add(btnPlus);
            pnlQuantity.Controls.Add(lblQuantity);
            pnlQuantity.Controls.Add(btnMinus);
            pnlQuantity.Location = new Point(20, 230);
            pnlQuantity.Name = "pnlQuantity";
            pnlQuantity.Size = new Size(480, 60);
            pnlQuantity.TabIndex = 6;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(20, 25, 35);
            btnPlus.Cursor = Cursors.Hand;
            btnPlus.FlatAppearance.BorderColor = Color.FromArgb(242, 192, 75);
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(310, 5);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(90, 50);
            btnPlus.TabIndex = 7;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(209, 5);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(62, 50);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "1";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.None;
            btnMinus.BackColor = Color.FromArgb(20, 25, 35);
            btnMinus.Cursor = Cursors.Hand;
            btnMinus.FlatAppearance.BorderColor = Color.FromArgb(242, 192, 75);
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(80, 5);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(90, 50);
            btnMinus.TabIndex = 5;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // pnlPriceInfo
            // 
            pnlPriceInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPriceInfo.BackColor = Color.Transparent;
            pnlPriceInfo.Controls.Add(lblSeparator);
            pnlPriceInfo.Controls.Add(lblExtraInfo);
            pnlPriceInfo.Controls.Add(lblPrice);
            pnlPriceInfo.Controls.Add(pbHeart);
            pnlPriceInfo.Location = new Point(20, 140);
            pnlPriceInfo.Name = "pnlPriceInfo";
            pnlPriceInfo.Size = new Size(480, 70);
            pnlPriceInfo.TabIndex = 4;
            // 
            // lblSeparator
            // 
            lblSeparator.BackColor = Color.FromArgb(60, 70, 90);
            lblSeparator.Location = new Point(290, 10);
            lblSeparator.Name = "lblSeparator";
            lblSeparator.Size = new Size(2, 40);
            lblSeparator.TabIndex = 3;
            lblSeparator.Text = "label1";
            // 
            // lblExtraInfo
            // 
            lblExtraInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExtraInfo.ForeColor = Color.White;
            lblExtraInfo.Location = new Point(310, 10);
            lblExtraInfo.Name = "lblExtraInfo";
            lblExtraInfo.Size = new Size(150, 40);
            lblExtraInfo.TabIndex = 2;
            lblExtraInfo.Text = "4 Hours";
            lblExtraInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(255, 190, 80);
            lblPrice.Location = new Point(50, 10);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(220, 40);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "200 Hearts";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbHeart
            // 
            pbHeart.Image = Properties.Resources.RedHeart;
            pbHeart.Location = new Point(0, 15);
            pbHeart.Name = "pbHeart";
            pbHeart.Size = new Size(32, 32);
            pbHeart.SizeMode = PictureBoxSizeMode.Zoom;
            pbHeart.TabIndex = 0;
            pbHeart.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(20, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(317, 46);
            lblName.TabIndex = 3;
            lblName.Text = "Product Name";
            // 
            // pnlCategory
            // 
            pnlCategory.BackColor = Color.FromArgb(5, 38, 53);
            pnlCategory.Controls.Add(lblCategory);
            pnlCategory.Location = new Point(20, 20);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(150, 40);
            pnlCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(0, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(150, 40);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDescription
            // 
            pnlDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDescription.BackColor = Color.Transparent;
            pnlDescription.Controls.Add(lblDescription);
            pnlDescription.Controls.Add(lblDescriptionTitle);
            pnlDescription.Location = new Point(20, 500);
            pnlDescription.Name = "pnlDescription";
            pnlDescription.Size = new Size(1520, 130);
            pnlDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(0, 50);
            lblDescription.MaximumSize = new Size(1500, 80);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1500, 80);
            lblDescription.TabIndex = 1;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescriptionTitle.ForeColor = Color.FromArgb(242, 192, 75);
            lblDescriptionTitle.Location = new Point(0, 0);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(350, 40);
            lblDescriptionTitle.TabIndex = 0;
            lblDescriptionTitle.Text = "About";
            // 
            // ProductDetailsPageControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 12, 20);
            Controls.Add(pnlDescription);
            Controls.Add(pnlInfo);
            Controls.Add(pbProductImage);
            Name = "ProductDetailsPageControl";
            Size = new Size(1582, 658);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlQuantity.ResumeLayout(false);
            pnlPriceInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHeart).EndInit();
            pnlCategory.ResumeLayout(false);
            pnlDescription.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbProductImage;
        private Panel pnlInfo;
        private Panel pnlCategory;
        private Label lblCategory;
        private Label lblName;
        private Panel pnlPriceInfo;
        private Label lblPrice;
        private PictureBox pbHeart;
        private Button btnMinus;
        private Panel pnlQuantity;
        private Label lblExtraInfo;
        private Label lblQuantity;
        private Button btnAddToCart;
        private Button btnPlus;
        private Panel pnlDescription;
        private Label lblDescriptionTitle;
        private Label lblDescription;
        private Label lblSeparator;
    }
}

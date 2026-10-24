namespace SurpriseBox.Controls
{
    partial class CartItemCard
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
            pnlContainer = new Panel();
            lblEach = new Label();
            btnDelete = new Button();
            pbHeartTotal = new PictureBox();
            lblTotalPrice = new Label();
            lblTotalCaption = new Label();
            pnlPriceSeparator = new Panel();
            lblUnitPrice = new Label();
            pbHeartUnit = new PictureBox();
            pnlSeparator = new Panel();
            pnlQuantity = new Panel();
            btnPlus = new Button();
            lblQuantity = new Label();
            btnMinus = new Button();
            lblExtraInfo = new Label();
            lblDescription = new Label();
            lblName = new Label();
            pnlCategory = new Panel();
            lblCategory = new Label();
            pbProductImage = new PictureBox();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeartTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeartUnit).BeginInit();
            pnlQuantity.SuspendLayout();
            pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.Transparent;
            pnlContainer.Controls.Add(lblEach);
            pnlContainer.Controls.Add(btnDelete);
            pnlContainer.Controls.Add(pbHeartTotal);
            pnlContainer.Controls.Add(lblTotalPrice);
            pnlContainer.Controls.Add(lblTotalCaption);
            pnlContainer.Controls.Add(pnlPriceSeparator);
            pnlContainer.Controls.Add(lblUnitPrice);
            pnlContainer.Controls.Add(pbHeartUnit);
            pnlContainer.Controls.Add(pnlSeparator);
            pnlContainer.Controls.Add(pnlQuantity);
            pnlContainer.Controls.Add(lblExtraInfo);
            pnlContainer.Controls.Add(lblDescription);
            pnlContainer.Controls.Add(lblName);
            pnlContainer.Controls.Add(pnlCategory);
            pnlContainer.Controls.Add(pbProductImage);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(460, 350);
            pnlContainer.TabIndex = 0;
            // 
            // lblEach
            // 
            lblEach.AutoSize = true;
            lblEach.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEach.ForeColor = Color.White;
            lblEach.Location = new Point(50, 325);
            lblEach.Name = "lblEach";
            lblEach.Size = new Size(46, 23);
            lblEach.TabIndex = 14;
            lblEach.Text = "each";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.DimGray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(405, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 40);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "🗑";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pbHeartTotal
            // 
            pbHeartTotal.Image = Properties.Resources.RedHeart;
            pbHeartTotal.Location = new Point(220, 320);
            pbHeartTotal.Name = "pbHeartTotal";
            pbHeartTotal.Size = new Size(26, 26);
            pbHeartTotal.SizeMode = PictureBoxSizeMode.Zoom;
            pbHeartTotal.TabIndex = 12;
            pbHeartTotal.TabStop = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.FromArgb(255, 215, 120);
            lblTotalPrice.Location = new Point(256, 316);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(135, 28);
            lblTotalPrice.TabIndex = 11;
            lblTotalPrice.Text = "Total Price";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.Font = new Font("Segoe UI", 8F);
            lblTotalCaption.ForeColor = Color.WhiteSmoke;
            lblTotalCaption.Location = new Point(220, 300);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(120, 18);
            lblTotalCaption.TabIndex = 10;
            lblTotalCaption.Text = "Total for this item:";
            // 
            // pnlPriceSeparator
            // 
            pnlPriceSeparator.BackColor = Color.DimGray;
            pnlPriceSeparator.Location = new Point(200, 300);
            pnlPriceSeparator.Name = "pnlPriceSeparator";
            pnlPriceSeparator.Size = new Size(1, 35);
            pnlPriceSeparator.TabIndex = 9;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUnitPrice.ForeColor = Color.FromArgb(255, 215, 120);
            lblUnitPrice.Location = new Point(50, 297);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(135, 28);
            lblUnitPrice.TabIndex = 8;
            lblUnitPrice.Text = "Unit Price";
            lblUnitPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbHeartUnit
            // 
            pbHeartUnit.Image = Properties.Resources.RedHeart;
            pbHeartUnit.Location = new Point(15, 299);
            pbHeartUnit.Name = "pbHeartUnit";
            pbHeartUnit.Size = new Size(26, 26);
            pbHeartUnit.SizeMode = PictureBoxSizeMode.Zoom;
            pbHeartUnit.TabIndex = 7;
            pbHeartUnit.TabStop = false;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.DimGray;
            pnlSeparator.Location = new Point(15, 295);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(420, 1);
            pnlSeparator.TabIndex = 6;
            // 
            // pnlQuantity
            // 
            pnlQuantity.BackColor = Color.Transparent;
            pnlQuantity.Controls.Add(btnPlus);
            pnlQuantity.Controls.Add(lblQuantity);
            pnlQuantity.Controls.Add(btnMinus);
            pnlQuantity.Location = new Point(295, 250);
            pnlQuantity.Name = "pnlQuantity";
            pnlQuantity.Size = new Size(150, 40);
            pnlQuantity.TabIndex = 5;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(10, 15, 25);
            btnPlus.Cursor = Cursors.Hand;
            btnPlus.FlatAppearance.BorderColor = Color.DimGray;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(110, 0);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(40, 40);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(45, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(60, 40);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "1";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(10, 15, 25);
            btnMinus.Cursor = Cursors.Hand;
            btnMinus.FlatAppearance.BorderColor = Color.DimGray;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(0, 0);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(40, 40);
            btnMinus.TabIndex = 0;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // lblExtraInfo
            // 
            lblExtraInfo.Font = new Font("Segoe UI", 11F);
            lblExtraInfo.ForeColor = Color.White;
            lblExtraInfo.Location = new Point(50, 255);
            lblExtraInfo.Name = "lblExtraInfo";
            lblExtraInfo.Size = new Size(140, 30);
            lblExtraInfo.TabIndex = 4;
            lblExtraInfo.Text = "4 hours";
            // 
            // lblDescription
            // 
            lblDescription.AutoEllipsis = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.WhiteSmoke;
            lblDescription.Location = new Point(15, 200);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(435, 50);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Item short description";
            // 
            // lblName
            // 
            lblName.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(15, 165);
            lblName.Name = "lblName";
            lblName.Size = new Size(300, 35);
            lblName.TabIndex = 2;
            lblName.Text = "Item Name";
            // 
            // pnlCategory
            // 
            pnlCategory.BackColor = Color.FromArgb(8, 12, 18);
            pnlCategory.Controls.Add(lblCategory);
            pnlCategory.Location = new Point(15, 12);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(120, 35);
            pnlCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(0, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(120, 35);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbProductImage
            // 
            pbProductImage.BackColor = Color.Transparent;
            pbProductImage.Image = Properties.Resources.DefaultProductCardImg;
            pbProductImage.Location = new Point(5, 5);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(450, 145);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // CartItemCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlContainer);
            Margin = new Padding(7, 0, 0, 0);
            Name = "CartItemCard";
            Size = new Size(460, 350);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeartTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeartUnit).EndInit();
            pnlQuantity.ResumeLayout(false);
            pnlCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlCategory;
        private PictureBox pbProductImage;
        private Label lblDescription;
        private Label lblName;
        private Label lblCategory;
        private Panel pnlQuantity;
        private Button btnPlus;
        private Label lblQuantity;
        private Button btnMinus;
        private Label lblExtraInfo;
        private Label lblTotalCaption;
        private Panel pnlPriceSeparator;
        private Label lblUnitPrice;
        private PictureBox pbHeartUnit;
        private Panel pnlSeparator;
        private PictureBox pbHeartTotal;
        private Label lblTotalPrice;
        private Button btnDelete;
        private Label lblEach;
    }
}

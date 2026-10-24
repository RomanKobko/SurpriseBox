namespace SurpriseBox.Controls
{
    partial class CartPageControl
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
            pnlCartHeader = new Panel();
            pnlItemsCounter = new Panel();
            lblItemsCounter = new Label();
            lblCartSubtitle = new Label();
            lblCartTitle = new Label();
            flpCartItems = new FlowLayoutPanel();
            btnPrevPage = new Button();
            btnNextPage = new Button();
            pnlOrderSummary = new Panel();
            pnlTotal = new Panel();
            lblTotalPrice = new Label();
            pbTotalHeart = new PictureBox();
            label2 = new Label();
            pnlExperienceInfo = new Panel();
            lblExperienceCount = new Label();
            pnlGiftInfo = new Panel();
            lblGiftCount = new Label();
            lblSummaryTitle = new Label();
            pnlActions = new Panel();
            btnClearCart = new Button();
            btnCheckout = new Button();
            pnlCartHeader.SuspendLayout();
            pnlItemsCounter.SuspendLayout();
            pnlOrderSummary.SuspendLayout();
            pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTotalHeart).BeginInit();
            pnlExperienceInfo.SuspendLayout();
            pnlGiftInfo.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCartHeader
            // 
            pnlCartHeader.BackColor = Color.Transparent;
            pnlCartHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlCartHeader.Controls.Add(pnlItemsCounter);
            pnlCartHeader.Controls.Add(lblCartSubtitle);
            pnlCartHeader.Controls.Add(lblCartTitle);
            pnlCartHeader.Location = new Point(20, 15);
            pnlCartHeader.Name = "pnlCartHeader";
            pnlCartHeader.Size = new Size(1542, 80);
            pnlCartHeader.TabIndex = 0;
            // 
            // pnlItemsCounter
            // 
            pnlItemsCounter.Controls.Add(lblItemsCounter);
            pnlItemsCounter.Location = new Point(1450, 20);
            pnlItemsCounter.Name = "pnlItemsCounter";
            pnlItemsCounter.Size = new Size(90, 40);
            pnlItemsCounter.TabIndex = 2;
            // 
            // lblItemsCounter
            // 
            lblItemsCounter.Dock = DockStyle.Fill;
            lblItemsCounter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemsCounter.ForeColor = Color.FromArgb(255, 215, 120);
            lblItemsCounter.Location = new Point(0, 0);
            lblItemsCounter.Name = "lblItemsCounter";
            lblItemsCounter.Size = new Size(90, 40);
            lblItemsCounter.TabIndex = 0;
            lblItemsCounter.Text = "items";
            lblItemsCounter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCartSubtitle
            // 
            lblCartSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCartSubtitle.ForeColor = Color.WhiteSmoke;
            lblCartSubtitle.Location = new Point(70, 45);
            lblCartSubtitle.Name = "lblCartSubtitle";
            lblCartSubtitle.Size = new Size(450, 25);
            lblCartSubtitle.TabIndex = 1;
            lblCartSubtitle.Text = "Review your experiences before checkout";
            // 
            // lblCartTitle
            // 
            lblCartTitle.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartTitle.ForeColor = Color.White;
            lblCartTitle.Location = new Point(70, 5);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(400, 45);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "Your SurpriseBox Cart";
            // 
            // flpCartItems
            // 
            flpCartItems.BackColor = Color.Transparent;
            flpCartItems.Location = new Point(90, 110);
            flpCartItems.Margin = new Padding(0);
            flpCartItems.Name = "flpCartItems";
            flpCartItems.Size = new Size(1402, 360);
            flpCartItems.TabIndex = 1;
            flpCartItems.WrapContents = false;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevPage.BackColor = Color.FromArgb(20, 25, 35);
            btnPrevPage.Cursor = Cursors.Hand;
            btnPrevPage.FlatAppearance.BorderSize = 0;
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevPage.ForeColor = Color.White;
            btnPrevPage.Location = new Point(20, 110);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(50, 360);
            btnPrevPage.TabIndex = 2;
            btnPrevPage.Text = "<";
            btnPrevPage.UseVisualStyleBackColor = false;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNextPage.BackColor = Color.FromArgb(20, 25, 35);
            btnNextPage.Cursor = Cursors.Hand;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btnNextPage.ForeColor = Color.White;
            btnNextPage.Location = new Point(1512, 110);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(50, 360);
            btnNextPage.TabIndex = 3;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // pnlOrderSummary
            // 
            pnlOrderSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderSummary.Controls.Add(pnlTotal);
            pnlOrderSummary.Controls.Add(pnlExperienceInfo);
            pnlOrderSummary.Controls.Add(pnlGiftInfo);
            pnlOrderSummary.Controls.Add(lblSummaryTitle);
            pnlOrderSummary.Location = new Point(20, 490);
            pnlOrderSummary.Name = "pnlOrderSummary";
            pnlOrderSummary.Size = new Size(1542, 80);
            pnlOrderSummary.TabIndex = 4;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.Transparent;
            pnlTotal.Controls.Add(lblTotalPrice);
            pnlTotal.Controls.Add(pbTotalHeart);
            pnlTotal.Controls.Add(label2);
            pnlTotal.Location = new Point(1040, 0);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(500, 80);
            pnlTotal.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.FromArgb(255, 215, 120);
            lblTotalPrice.Location = new Point(218, 12);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(252, 54);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "1920 Hearts";
            // 
            // pbTotalHeart
            // 
            pbTotalHeart.Image = Properties.Resources.RedHeart;
            pbTotalHeart.Location = new Point(170, 22);
            pbTotalHeart.Name = "pbTotalHeart";
            pbTotalHeart.Size = new Size(36, 36);
            pbTotalHeart.SizeMode = PictureBoxSizeMode.Zoom;
            pbTotalHeart.TabIndex = 1;
            pbTotalHeart.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 20);
            label2.Name = "label2";
            label2.Size = new Size(96, 40);
            label2.TabIndex = 0;
            label2.Text = "Total:";
            // 
            // pnlExperienceInfo
            // 
            pnlExperienceInfo.Controls.Add(lblExperienceCount);
            pnlExperienceInfo.Location = new Point(520, 15);
            pnlExperienceInfo.Name = "pnlExperienceInfo";
            pnlExperienceInfo.Size = new Size(270, 50);
            pnlExperienceInfo.TabIndex = 2;
            // 
            // lblExperienceCount
            // 
            lblExperienceCount.BackColor = Color.Transparent;
            lblExperienceCount.Font = new Font("Segoe UI", 10.8F);
            lblExperienceCount.ForeColor = Color.White;
            lblExperienceCount.Location = new Point(50, 12);
            lblExperienceCount.Name = "lblExperienceCount";
            lblExperienceCount.Size = new Size(210, 25);
            lblExperienceCount.TabIndex = 0;
            lblExperienceCount.Text = "Experience duration: 100 hours";
            // 
            // pnlGiftInfo
            // 
            pnlGiftInfo.Controls.Add(lblGiftCount);
            pnlGiftInfo.Location = new Point(320, 15);
            pnlGiftInfo.Name = "pnlGiftInfo";
            pnlGiftInfo.Size = new Size(180, 50);
            pnlGiftInfo.TabIndex = 1;
            // 
            // lblGiftCount
            // 
            lblGiftCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiftCount.ForeColor = Color.White;
            lblGiftCount.Location = new Point(60, 12);
            lblGiftCount.Name = "lblGiftCount";
            lblGiftCount.Size = new Size(110, 25);
            lblGiftCount.TabIndex = 0;
            lblGiftCount.Text = "Gifts: 100 pcs";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryTitle.ForeColor = Color.White;
            lblSummaryTitle.Location = new Point(80, 20);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(220, 40);
            lblSummaryTitle.TabIndex = 0;
            lblSummaryTitle.Text = "Order summary";
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnClearCart);
            pnlActions.Controls.Add(btnCheckout);
            pnlActions.Location = new Point(260, 590);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1050, 60);
            pnlActions.TabIndex = 5;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(15, 20, 30);
            btnClearCart.Cursor = Cursors.Hand;
            btnClearCart.FlatAppearance.BorderColor = Color.FromArgb(255, 215, 120);
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClearCart.ForeColor = Color.Red;
            btnClearCart.Location = new Point(550, 0);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(500, 50);
            btnClearCart.TabIndex = 1;
            btnClearCart.Text = "Clear shopping cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(255, 215, 120);
            btnCheckout.Cursor = Cursors.Hand;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.Black;
            btnCheckout.Location = new Point(0, 0);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(500, 50);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Place an order";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // CartPageControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 12, 20);
            Controls.Add(pnlActions);
            Controls.Add(pnlOrderSummary);
            Controls.Add(btnNextPage);
            Controls.Add(btnPrevPage);
            Controls.Add(flpCartItems);
            Controls.Add(pnlCartHeader);
            Name = "CartPageControl";
            Size = new Size(1582, 658);
            pnlCartHeader.ResumeLayout(false);
            pnlItemsCounter.ResumeLayout(false);
            pnlOrderSummary.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTotalHeart).EndInit();
            pnlExperienceInfo.ResumeLayout(false);
            pnlGiftInfo.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCartHeader;
        private Panel pnlItemsCounter;
        private Label lblItemsCounter;
        private Label lblCartSubtitle;
        private Label lblCartTitle;
        private FlowLayoutPanel flpCartItems;
        private Button btnPrevPage;
        private Button btnNextPage;
        private Panel pnlOrderSummary;
        private Panel pnlGiftInfo;
        private Label lblGiftCount;
        private Label lblSummaryTitle;
        private Panel pnlExperienceInfo;
        private Label lblExperienceCount;
        private Panel pnlTotal;
        private Label lblTotalPrice;
        private PictureBox pbTotalHeart;
        private Label label2;
        private Panel pnlActions;
        private Button btnClearCart;
        private Button btnCheckout;
    }
}

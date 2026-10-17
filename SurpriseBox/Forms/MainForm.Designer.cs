namespace SurpriseBox.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlHeader = new Panel();
            pbLogo = new PictureBox();
            btnHome = new Button();
            btnCart = new Button();
            btnSettings = new Button();
            pbAvatar = new PictureBox();
            lblUserName = new Label();
            pbHeart = new PictureBox();
            lblHearts = new Label();
            pbBanner = new PictureBox();
            lblBannerTitle = new Label();
            lblBannerSubtitle = new Label();
            pnlContent = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBanner).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.FromArgb(15, 20, 30);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1582, 95);
            pnlHeader.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.FromArgb(15, 20, 30);
            pbLogo.Image = Properties.Resources.SurpriseBoxFullLogo;
            pbLogo.Location = new Point(20, 5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(350, 85);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(35, 40, 50);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 85);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(460, 22);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(170, 50);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.FromArgb(35, 40, 50);
            btnCart.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 85);
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI", 11F);
            btnCart.ForeColor = Color.White;
            btnCart.Location = new Point(640, 22);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(170, 50);
            btnCart.TabIndex = 3;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(35, 40, 50);
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 85);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 11F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(820, 22);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(170, 50);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.FromArgb(15, 20, 30);
            pbAvatar.ErrorImage = Properties.Resources.DefaultAvatar;
            pbAvatar.Image = Properties.Resources.DefaultAvatar;
            pbAvatar.Location = new Point(1210, 15);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(65, 65);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 5;
            pbAvatar.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.FromArgb(15, 20, 30);
            lblUserName.Font = new Font("Segoe UI", 11F);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(1285, 18);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(123, 25);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "Alex Johnson";
            // 
            // pbHeart
            // 
            pbHeart.BackColor = Color.FromArgb(15, 20, 30);
            pbHeart.Image = Properties.Resources.RedHeart;
            pbHeart.Location = new Point(1285, 48);
            pbHeart.Name = "pbHeart";
            pbHeart.Size = new Size(18, 18);
            pbHeart.SizeMode = PictureBoxSizeMode.Zoom;
            pbHeart.TabIndex = 7;
            pbHeart.TabStop = false;
            // 
            // lblHearts
            // 
            lblHearts.AutoSize = true;
            lblHearts.BackColor = Color.FromArgb(15, 20, 30);
            lblHearts.Font = new Font("Segoe UI", 11F);
            lblHearts.ForeColor = Color.White;
            lblHearts.Location = new Point(1312, 45);
            lblHearts.Name = "lblHearts";
            lblHearts.Size = new Size(111, 25);
            lblHearts.TabIndex = 8;
            lblHearts.Text = "1250 Hearts";
            // 
            // pbBanner
            // 
            pbBanner.BackColor = Color.FromArgb(15, 20, 30);
            pbBanner.Location = new Point(30, 105);
            pbBanner.Name = "pbBanner";
            pbBanner.Size = new Size(1520, 90);
            pbBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBanner.TabIndex = 9;
            pbBanner.TabStop = false;
            // 
            // lblBannerTitle
            // 
            lblBannerTitle.AutoSize = true;
            lblBannerTitle.BackColor = Color.Transparent;
            lblBannerTitle.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBannerTitle.ForeColor = Color.FromArgb(255, 215, 120);
            lblBannerTitle.Location = new Point(55, 108);
            lblBannerTitle.Name = "lblBannerTitle";
            lblBannerTitle.Size = new Size(404, 84);
            lblBannerTitle.TabIndex = 10;
            lblBannerTitle.Text = "Extraordinary Experiences\nfor Extraordinary People";
            // 
            // lblBannerSubtitle
            // 
            lblBannerSubtitle.AutoSize = true;
            lblBannerSubtitle.BackColor = Color.Transparent;
            lblBannerSubtitle.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBannerSubtitle.ForeColor = Color.White;
            lblBannerSubtitle.Location = new Point(1140, 135);
            lblBannerSubtitle.Name = "lblBannerSubtitle";
            lblBannerSubtitle.Size = new Size(380, 33);
            lblBannerSubtitle.TabIndex = 11;
            lblBannerSubtitle.Text = "Discover. Gift. Create Memories.";
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = Color.Transparent;
            pnlContent.Location = new Point(0, 195);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1582, 658);
            pnlContent.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 12, 18);
            ClientSize = new Size(1582, 853);
            Controls.Add(pnlContent);
            Controls.Add(lblBannerSubtitle);
            Controls.Add(lblBannerTitle);
            Controls.Add(pbBanner);
            Controls.Add(lblHearts);
            Controls.Add(pbHeart);
            Controls.Add(lblUserName);
            Controls.Add(pbAvatar);
            Controls.Add(btnSettings);
            Controls.Add(btnCart);
            Controls.Add(btnHome);
            Controls.Add(pbLogo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SurpriseBox";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pbLogo;
        private Button btnHome;
        private Button btnCart;
        private Button btnSettings;
        private PictureBox pbAvatar;
        private Label lblUserName;
        private PictureBox pbHeart;
        private Label lblHearts;
        private PictureBox pbBanner;
        private Label lblBannerTitle;
        private Label lblBannerSubtitle;
        private Panel pnlContent;
    }
}
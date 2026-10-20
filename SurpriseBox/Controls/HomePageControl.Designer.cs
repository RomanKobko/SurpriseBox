namespace SurpriseBox.Controls
{
    partial class HomePageControl
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
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            flpProducts = new FlowLayoutPanel();
            pnlPagination = new Panel();
            btnNext = new Button();
            lblPageInfo = new Label();
            btnPrev = new Button();
            pnlSearch.SuspendLayout();
            pnlPagination.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(18, 25, 35);
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Location = new Point(25, 15);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1520, 50);
            pnlSearch.TabIndex = 13;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(18, 25, 35);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.ForeColor = Color.Gainsboro;
            txtSearch.Location = new Point(20, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for experiences, destinations, or special moments...";
            txtSearch.Size = new Size(1360, 25);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(245, 180, 70);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1402, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 32);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // flpProducts
            // 
            flpProducts.BackColor = Color.Transparent;
            flpProducts.Location = new Point(20, 85);
            flpProducts.Margin = new Padding(0);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(1530, 510);
            flpProducts.TabIndex = 17;
            // 
            // pnlPagination
            // 
            pnlPagination.Anchor = AnchorStyles.Bottom;
            pnlPagination.BackColor = Color.Transparent;
            pnlPagination.Controls.Add(btnNext);
            pnlPagination.Controls.Add(lblPageInfo);
            pnlPagination.Controls.Add(btnPrev);
            pnlPagination.Location = new Point(640, 610);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(300, 40);
            pnlPagination.TabIndex = 17;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(20, 25, 35);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(260, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 40);
            btnNext.TabIndex = 2;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = Color.White;
            lblPageInfo.Location = new Point(50, 0);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(200, 40);
            lblPageInfo.TabIndex = 1;
            lblPageInfo.Text = "1 з 1";
            lblPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.FromArgb(20, 25, 35);
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(0, 0);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 40);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // HomePageControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 12, 20);
            Controls.Add(pnlPagination);
            Controls.Add(flpProducts);
            Controls.Add(pnlSearch);
            Name = "HomePageControl";
            Size = new Size(1582, 658);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlPagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private FlowLayoutPanel flpProducts;
        private Panel pnlPagination;
        private Button btnNext;
        private Label lblPageInfo;
        private Button btnPrev;
    }
}

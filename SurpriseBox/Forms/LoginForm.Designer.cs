namespace SurpriseBox.Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pbLogo = new PictureBox();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblEmail = new Label();
            pnlEmail = new Panel();
            txtEmail = new TextBox();
            lblPassword = new Label();
            pnlPassword = new Panel();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            lblForgotPassword = new Label();
            btnSignIn = new Button();
            pnlDivider = new Panel();
            lblNoAccount = new Label();
            lblCreateOne = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = Properties.Resources.SurpriseBoxFullLogo;
            pbLogo.Location = new Point(140, 70);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(400, 97);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(60, 220);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(297, 54);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome Back";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(139, 143, 156);
            lblSubtitle.Location = new Point(60, 270);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(323, 28);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to your SurpriseBox account";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(60, 340);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(130, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email Address";
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.FromArgb(28, 32, 42);
            pnlEmail.Location = new Point(60, 370);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(560, 52);
            pnlEmail.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(28, 32, 42);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.White;
            txtEmail.ImeMode = ImeMode.NoControl;
            txtEmail.Location = new Point(70, 384);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "you@example.com";
            txtEmail.Size = new Size(540, 25);
            txtEmail.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(60, 450);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(28, 32, 42);
            pnlPassword.Location = new Point(60, 480);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(560, 52);
            pnlPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(28, 32, 42);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(70, 494);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(540, 25);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.BackColor = Color.Transparent;
            chkRemember.Font = new Font("Segoe UI", 11F);
            chkRemember.ForeColor = Color.FromArgb(154, 157, 172);
            chkRemember.Location = new Point(60, 585);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(155, 29);
            chkRemember.TabIndex = 9;
            chkRemember.Text = "Remember me";
            chkRemember.UseVisualStyleBackColor = false;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Cursor = Cursors.Hand;
            lblForgotPassword.Font = new Font("Segoe UI", 11F);
            lblForgotPassword.ForeColor = Color.DarkOrange;
            lblForgotPassword.Location = new Point(470, 590);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(161, 25);
            lblForgotPassword.TabIndex = 10;
            lblForgotPassword.Text = "Forgot password?";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DarkOrange;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(60, 645);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(560, 65);
            btnSignIn.TabIndex = 11;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(61, 66, 80);
            pnlDivider.Location = new Point(60, 780);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(560, 1);
            pnlDivider.TabIndex = 12;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Segoe UI", 11F);
            lblNoAccount.ForeColor = Color.FromArgb(139, 143, 156);
            lblNoAccount.Location = new Point(175, 815);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(209, 25);
            lblNoAccount.TabIndex = 13;
            lblNoAccount.Text = "Don't have an account?";
            // 
            // lblCreateOne
            // 
            lblCreateOne.AutoSize = true;
            lblCreateOne.Cursor = Cursors.Hand;
            lblCreateOne.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateOne.ForeColor = Color.DarkOrange;
            lblCreateOne.Location = new Point(385, 815);
            lblCreateOne.Name = "lblCreateOne";
            lblCreateOne.Size = new Size(104, 25);
            lblCreateOne.TabIndex = 14;
            lblCreateOne.Text = "Create one";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 12, 18);
            ClientSize = new Size(662, 853);
            Controls.Add(lblCreateOne);
            Controls.Add(lblNoAccount);
            Controls.Add(pnlDivider);
            Controls.Add(btnSignIn);
            Controls.Add(lblForgotPassword);
            Controls.Add(chkRemember);
            Controls.Add(txtPassword);
            Controls.Add(pnlPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(pnlEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(pbLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblEmail;
        private Panel pnlEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private Panel pnlPassword;
        private TextBox txtPassword;
        private CheckBox chkRemember;
        private Label lblForgotPassword;
        private Button btnSignIn;
        private Panel pnlDivider;
        private Label lblNoAccount;
        private Label lblCreateOne;
    }
}

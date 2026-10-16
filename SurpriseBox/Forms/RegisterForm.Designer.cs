namespace SurpriseBox.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pbLogo = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFirstName = new Label();
            pnlFirstName = new Panel();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            pnlLastName = new Panel();
            txtLastName = new TextBox();
            lblEmail = new Label();
            pnlEmail = new Panel();
            txtEmail = new TextBox();
            lblPhone = new Label();
            pnlPhone = new Panel();
            txtPhone = new TextBox();
            lblPassword = new Label();
            pnlPassword = new Panel();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            pnlConfirmPassword = new Panel();
            txtConfirmPassword = new TextBox();
            chkTerms = new CheckBox();
            btnCreateAccount = new Button();
            pnlDivider = new Panel();
            lblHaveAccount = new Label();
            lblSignIn = new Label();
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(60, 190);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Create Account";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(139, 143, 156);
            lblSubtitle.Location = new Point(60, 240);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(308, 23);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Join SurpriseBox and start your journey";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(60, 285);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 23);
            lblFirstName.TabIndex = 15;
            lblFirstName.Text = "First Name";
            // 
            // pnlFirstName
            // 
            pnlFirstName.BackColor = Color.FromArgb(28, 32, 42);
            pnlFirstName.Location = new Point(60, 310);
            pnlFirstName.Name = "pnlFirstName";
            pnlFirstName.Size = new Size(560, 40);
            pnlFirstName.TabIndex = 16;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(28, 32, 42);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(75, 321);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Enter your first name";
            txtFirstName.Size = new Size(530, 23);
            txtFirstName.TabIndex = 17;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(60, 360);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(91, 23);
            lblLastName.TabIndex = 18;
            lblLastName.Text = "Last Name";
            // 
            // pnlLastName
            // 
            pnlLastName.BackColor = Color.FromArgb(28, 32, 42);
            pnlLastName.Location = new Point(60, 385);
            pnlLastName.Name = "pnlLastName";
            pnlLastName.Size = new Size(560, 40);
            pnlLastName.TabIndex = 19;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(28, 32, 42);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(75, 396);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Enter your last name";
            txtLastName.Size = new Size(530, 23);
            txtLastName.TabIndex = 20;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(60, 435);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(116, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email Address";
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.FromArgb(28, 32, 42);
            pnlEmail.Location = new Point(60, 460);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(560, 40);
            pnlEmail.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(28, 32, 42);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.White;
            txtEmail.ImeMode = ImeMode.NoControl;
            txtEmail.Location = new Point(75, 471);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "you@example.com";
            txtEmail.Size = new Size(530, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(60, 510);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(127, 23);
            lblPhone.TabIndex = 21;
            lblPhone.Text = "Phone Number";
            // 
            // pnlPhone
            // 
            pnlPhone.BackColor = Color.FromArgb(28, 32, 42);
            pnlPhone.Location = new Point(60, 535);
            pnlPhone.Name = "pnlPhone";
            pnlPhone.Size = new Size(560, 40);
            pnlPhone.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(28, 32, 42);
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(75, 546);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+380 XX XXX XX XX";
            txtPhone.Size = new Size(530, 20);
            txtPhone.TabIndex = 23;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(60, 585);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(28, 32, 42);
            pnlPassword.Location = new Point(60, 610);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(560, 40);
            pnlPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(28, 32, 42);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(75, 621);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(530, 23);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(60, 660);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(146, 23);
            lblConfirmPassword.TabIndex = 24;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // pnlConfirmPassword
            // 
            pnlConfirmPassword.BackColor = Color.FromArgb(28, 32, 42);
            pnlConfirmPassword.Location = new Point(60, 685);
            pnlConfirmPassword.Name = "pnlConfirmPassword";
            pnlConfirmPassword.Size = new Size(560, 40);
            pnlConfirmPassword.TabIndex = 25;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(28, 32, 42);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(75, 696);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Re-enter your password";
            txtConfirmPassword.Size = new Size(530, 23);
            txtConfirmPassword.TabIndex = 26;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // chkTerms
            // 
            chkTerms.AutoSize = true;
            chkTerms.BackColor = Color.Transparent;
            chkTerms.Font = new Font("Segoe UI", 9F);
            chkTerms.ForeColor = Color.FromArgb(154, 157, 172);
            chkTerms.Location = new Point(60, 745);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(284, 24);
            chkTerms.TabIndex = 9;
            chkTerms.Text = "I agree to the Terms and Privacy Policy";
            chkTerms.UseVisualStyleBackColor = false;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.DarkOrange;
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(60, 780);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(560, 65);
            btnCreateAccount.TabIndex = 11;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(61, 66, 80);
            pnlDivider.Location = new Point(60, 858);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(560, 1);
            pnlDivider.TabIndex = 12;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.AutoSize = true;
            lblHaveAccount.Font = new Font("Segoe UI", 10F);
            lblHaveAccount.ForeColor = Color.FromArgb(139, 143, 156);
            lblHaveAccount.Location = new Point(175, 868);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(206, 23);
            lblHaveAccount.TabIndex = 13;
            lblHaveAccount.Text = "Already have an account?";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Cursor = Cursors.Hand;
            lblSignIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = Color.DarkOrange;
            lblSignIn.Location = new Point(390, 868);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(66, 23);
            lblSignIn.TabIndex = 14;
            lblSignIn.Text = "Sign In";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 12, 18);
            ClientSize = new Size(662, 933);
            Controls.Add(txtConfirmPassword);
            Controls.Add(pnlConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPhone);
            Controls.Add(pnlPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtLastName);
            Controls.Add(pnlLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(pnlFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(lblSignIn);
            Controls.Add(lblHaveAccount);
            Controls.Add(pnlDivider);
            Controls.Add(btnCreateAccount);
            Controls.Add(chkTerms);
            Controls.Add(txtPassword);
            Controls.Add(pnlPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(pnlEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pbLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFirstName;
        private Panel pnlFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Panel pnlLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private Panel pnlEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private Panel pnlPhone;
        private TextBox txtPhone;
        private Label lblPassword;
        private Panel pnlPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private Panel pnlConfirmPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkTerms;
        private Button btnCreateAccount;
        private Panel pnlDivider;
        private Label lblHaveAccount;
        private Label lblSignIn;
    }
}

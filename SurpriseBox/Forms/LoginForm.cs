namespace SurpriseBox.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //ToDo : Implement the login logic here, such as validating user credentials and handling authentication.
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

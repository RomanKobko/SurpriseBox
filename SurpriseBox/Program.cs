using SurpriseBox.Forms;

namespace SurpriseBox
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable dark theme for the entire application
            Application.SetColorMode(SystemColorMode.Dark);

            ApplicationConfiguration.Initialize();

            // Create an instance of the login form
            var loginForm = new LoginForm();

            // If login is successful, launch the main application form
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
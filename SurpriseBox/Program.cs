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

            var loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }



            //Application.Run(new LoginForm());
            //Application.Run(new RegisterForm());
        }
    }
}
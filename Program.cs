using System;
using System.Windows.Forms;
using YourProply.Presenters;
using YourProply.Entities;

namespace YourProply
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var context = new YourProplyDbContext())
            {
                // Inicjalizacja formularza logowania
                var loginView = new Login();
                var loginPresenter = new LoginPresenter(loginView, context);

                // Dodanie logiki nawigacji do formularza rejestracji
                loginView.RegisterClick += (s, e) =>
                {
                    loginView.Hide();
                    var registerView = new RegisterLandlordForm();
                    var registerPresenter = new RegisterPresenter(registerView, context);
                    registerView.ShowDialog();
                    loginView.Show();
                };

                Application.Run(loginView);
            }
        }
    }
}

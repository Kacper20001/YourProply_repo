using System;
using System.Linq;
using YourProply.Entities;
using YourProply.Views;
using YourProply.Services;
using YourProply.Helpers;

namespace YourProply.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly YourProplyDbContext _context;
        private readonly OpenAIService _openAIService;

        public LoginPresenter(ILoginView view, YourProplyDbContext context, OpenAIService openAIService)
        {
            _view = view;
            _context = context;
            _openAIService = openAIService;
            _view.LoginEvent += OnLogin;
            _view.RegisterClick += OnRegisterClick;
            _view.CloseAppClick += OnCloseAppClick;
        }

        /// <summary>
        /// Metoda obsługująca zdarzenie logowania użytkownika.
        /// </summary>
        private void OnLogin(object sender, EventArgs e)
        {
            // Sprawdzenie, czy wszystkie wymagane pola są wypełnione
            if (string.IsNullOrWhiteSpace(_view.UserName) || string.IsNullOrWhiteSpace(_view.Password))
            {
                _view.ShowMessage("Wszystkie pola muszą być wypełnione");
                return;
            }

            // Znalezienie użytkownika w bazie danych
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == _view.UserName);

            // Walidacja użytkownika
            if (user == null || !PasswordHelper.VerifyPassword(_view.Password, user.Password))
            {
                _view.ShowMessage("Invalid username or password.");
                return;
            }

            // Ukrycie widoku logowania i wyświetlenie odpowiedniego menu
            _view.Hide();
            if (user.UserType == UserType.Landlord)
            {
                var landlordMenu = new LandlordMenu(user);
                var landlordMenuPresenter = new LandlordMenuPresenter(landlordMenu, _context, user, _openAIService);
                landlordMenu.FormClosed += (s, args) => _view.Close();
                landlordMenu.Show();
            }
            else if (user.UserType == UserType.Tenant)
            {
                var tenantMenu = new TenantMenu(user);
                var tenantMenuPresenter = new TenantMenuPresenter(tenantMenu, _context, user);
                tenantMenu.FormClosed += (s, args) => _view.Close();
                tenantMenu.Show();
            }
        }

        /// <summary>
        /// Metoda obsługująca zdarzenie kliknięcia przycisku rejestracji.
        /// </summary>
        private void OnRegisterClick(object sender, EventArgs e)
        {
            var registerView = new RegisterLandlordForm();
            var registerPresenter = new RegisterPresenter(registerView, _context, _openAIService);
            _view.Hide();
            registerView.FormClosed += (s, args) => _view.Show();
            registerView.ShowDialog();
            _view.Close();
        }

        /// <summary>
        /// Metoda obsługująca zdarzenie zamknięcia aplikacji.
        /// </summary>
        private void OnCloseAppClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

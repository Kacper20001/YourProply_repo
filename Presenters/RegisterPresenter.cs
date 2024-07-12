using System;
using System.Linq;
using System.Text.RegularExpressions;
using YourProply.Entities;
using YourProply.Helpers;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly YourProplyDbContext _context;
        private readonly OpenAIService _openAIService;

        public RegisterPresenter(IRegisterView view, YourProplyDbContext context, OpenAIService openAIService)
        {
            _openAIService = openAIService;
            _view = view;
            _context = context;
            _view.Register += OnRegister;
            _view.AlreadyHaveAccountClick += OnAlreadyHaveAccountClick;
        }

        /// <summary>
        /// Metoda obsługująca zdarzenie rejestracji użytkownika.
        /// </summary>
        private void OnRegister(object sender, EventArgs e)
        {
            // Sprawdzenie, czy hasła są identyczne
            if (_view.Password != _view.ConfirmPassword)
            {
                _view.ShowMessage("Hasła nie są identyczne");
                return;
            }

            // Walidacja hasła
            if (!IsValidPassword(_view.Password))
            {
                _view.ShowMessage("Hasło musi mieć co najmniej 8 znaków, zawierać co najmniej jedną cyfrę i jeden znak specjalny.");
                return;
            }

            // Sprawdzenie, czy wiek jest powyżej 18 lat
            if (!IsValidAge(_view.DateOfBirth))
            {
                _view.ShowMessage("Użytkownik musi mieć co najmniej 18 lat.");
                return;
            }

            // Walidacja pola email tylko @outlook.com ponieważ tak skonfiguorwałem SMTP
            if (!IsValidEmail(_view.Email))
            {
                _view.ShowMessage("Email musi należeć do domeny @outlook.com");
                return;
            }

            // Sprawdzenie, czy wszystkie wymagane pola są wypełnione
            if (string.IsNullOrWhiteSpace(_view.UserName) || string.IsNullOrWhiteSpace(_view.FirstName) ||
                string.IsNullOrWhiteSpace(_view.LastName) || string.IsNullOrWhiteSpace(_view.IdNumber) ||
                string.IsNullOrWhiteSpace(_view.Email) || string.IsNullOrWhiteSpace(_view.Password) ||
                string.IsNullOrWhiteSpace(_view.Street) || string.IsNullOrWhiteSpace(_view.Number) ||
                string.IsNullOrWhiteSpace(_view.City) || string.IsNullOrWhiteSpace(_view.PostalCode) ||
                string.IsNullOrWhiteSpace(_view.Province) || string.IsNullOrWhiteSpace(_view.State))
            {
                _view.ShowMessage("Wszystkie pola muszą być wypełnione");
                return;
            }

            // Sprawdzenie, czy użytkownik o podanej nazwie lub adresie email już istnieje
            var existingUser = _context.Users
                .FirstOrDefault(u => u.UserName == _view.UserName || u.Email == _view.Email);

            if (existingUser != null)
            {
                _view.ShowMessage("Użytkownik o podanej nazwie lub adresie email już istnieje.");
                return;
            }

            // Dodanie adresu użytkownika
            var address = new Address
            {
                Street = _view.Street,
                Number = _view.Number,
                City = _view.City,
                PostalCode = _view.PostalCode,
                Province = _view.Province,
                State = _view.State
            };

            _context.Addresses.Add(address);
            _context.SaveChanges();

            var hashedPassword = PasswordHelper.HashPassword(_view.Password);

            // Dodanie użytkownika
            var landlord = new Landlord
            {
                UserName = _view.UserName,
                FirstName = _view.FirstName,
                LastName = _view.LastName,
                Email = _view.Email,
                Password = hashedPassword,
                Address = address,
                UserType = UserType.Landlord,
                DateOfBirth = _view.DateOfBirth
            };

            _context.Users.Add(landlord);
            _context.SaveChanges();

            _view.ShowMessage("Zarejestrowano!");
            _view.ClearForm();
            _view.Hide();
            var loginView = new Login();
            var loginPresenter = new LoginPresenter(loginView, _context, _openAIService);
            loginView.ShowDialog();
            _view.Close();
        }

        /// <summary>
        /// Walidacja adresu email - musi należeć do domeny @outlook.com ponieważ tak skonfigurowałem SMTP
        /// </summary>
        private bool IsValidEmail(string email)
        {
            var regex = new Regex(@"^[^@\s]+@outlook\.com$");
            return regex.IsMatch(email);
        }

        /// <summary>
        /// Metoda obsługująca zdarzenie kliknięcia przycisku, gdy już użytkownuik posiada konto 
        /// </summary>
        private void OnAlreadyHaveAccountClick(object sender, EventArgs e)
        {
            var loginView = new Login();
            var loginPresenter = new LoginPresenter(loginView, _context, _openAIService);
            _view.Hide();
            loginView.FormClosed += (s, args) => _view.Show();
            loginView.ShowDialog();
        }
        /// <summary>
        /// Walidacja hasła - musi mieć co najmniej 8 znaków, zawierać co najmniej jedną cyfrę i jeden znak specjalny.
        /// </summary>
        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }
        /// <summary>
        /// Sprawdza, czy wiek jest większy lub równy 18 lat.
        /// </summary>
        /// <param name="dateOfBirth">Data urodzenia.</param>
        /// <returns>True, jeśli wiek jest większy lub równy 18 lat, w przeciwnym razie False.</returns>
        private bool IsValidAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age >= 18;
        }

    }
}

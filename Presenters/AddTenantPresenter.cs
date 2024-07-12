using System;
using System.Linq;
using System.Text.RegularExpressions;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class AddTenantPresenter
    {
        private readonly IAddTenantView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;

        public AddTenantPresenter(IAddTenantView view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.AddTenantClick += OnAddTenantClick;
        }

        /// <summary>
        /// Metoda obsługująca zdarzenie dodawania najemcy.
        /// </summary>
        private void OnAddTenantClick(object sender, EventArgs e)
        {
            // Walidacja pola email (tylko @outlook.com, ponieważ tak skonfigurowałem SMTP)
            if (!IsValidEmail(_view.Email))
            {
                _view.ShowMessage("Email musi należeć do domeny @outlook.com");
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

            // Sprawdzenie, czy wszystkie wymagane pola są wypełnione
            if (string.IsNullOrWhiteSpace(_view.UserName) || string.IsNullOrWhiteSpace(_view.FirstName) ||
                string.IsNullOrWhiteSpace(_view.LastName) || string.IsNullOrWhiteSpace(_view.IdNumber) ||
                string.IsNullOrWhiteSpace(_view.Email) || string.IsNullOrWhiteSpace(_view.Password) ||
                string.IsNullOrWhiteSpace(_view.Street) || string.IsNullOrWhiteSpace(_view.HouseNumber) ||
                string.IsNullOrWhiteSpace(_view.City) || string.IsNullOrWhiteSpace(_view.PostalCode) ||
                string.IsNullOrWhiteSpace(_view.Province) || string.IsNullOrWhiteSpace(_view.State))
            {
                _view.ShowMessage("Wszystkie pola muszą być wypełnione");
                return;
            }

            // Sprawdzenie, czy użytkownik o podanej nazwie lub adresie email już istnieje
            var existingUser = _context.Users
                .FirstOrDefault(u => u.UserName == _view.UserName || u.Email == _view.Email);

            if (existingUser != null && existingUser.UserId != _view.UserId)
            {
                _view.ShowMessage("Użytkownik o podanej nazwie lub adresie email już istnieje");
                return;
            }

            // Sprawdzenie, czy wybrana nieruchomość istnieje
            var selectedProperty = _context.Properties.FirstOrDefault(p => p.PropertyId == _view.SelectedPropertyId);
            if (selectedProperty == null)
            {
                _view.ShowMessage("Wybrana nieruchomość nie istnieje.");
                return;
            }

            // Dodanie/aktualizacja danych najemcy w zależności od wyboru przycisku czy Add czy Edit
            var tenant = _context.Users.OfType<Tenant>().FirstOrDefault(t => t.Email == _view.Email) ?? new Tenant();
            var address = tenant.Address ?? new Address();

            address.Street = _view.Street;
            address.Number = _view.HouseNumber;
            address.City = _view.City;
            address.PostalCode = _view.PostalCode;
            address.Province = _view.Province;
            address.State = _view.State;

            tenant.UserName = _view.UserName;
            tenant.FirstName = _view.FirstName;
            tenant.LastName = _view.LastName;
            tenant.Email = _view.Email;
            tenant.Password = _view.Password;
            tenant.Address = address;
            tenant.UserType = UserType.Tenant;
            tenant.DateOfBirth = _view.DateOfBirth;
            tenant.Property = selectedProperty;
            tenant.LandlordId = _loggedInUser.UserId;

            if (tenant.UserId == 0)
            {
                _context.Users.Add(tenant);
            }
            else
            {
                _context.Users.Update(tenant);
            }

            _context.SaveChanges();

            _view.ShowMessage("Zapisano");
            _view.Close();
        }

        /// <summary>
        /// Walidacja adresu email - musi należeć do domeny @outlook.com, ponieważ tak skonfigurowałem SMTP
        /// </summary>
        private bool IsValidEmail(string email)
        {
            var regex = new Regex(@"^[^@\s]+@outlook\.com$");
            return regex.IsMatch(email);
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

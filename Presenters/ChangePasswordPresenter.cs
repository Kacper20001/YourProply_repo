using System;
using System.Linq;
using System.Text.RegularExpressions;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class ChangePasswordPresenter
    {
        private readonly IChangePasswordView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;

        public ChangePasswordPresenter(IChangePasswordView view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.SaveClick += OnSaveClick;
        }

        /// <summary>
        /// Metoda obsługująca zdarzenie zmiany hasła.
        /// </summary>
        private void OnSaveClick(object sender, EventArgs e)
        {
            // Sprawdzenie, czy stare hasło jest prawidłowe
            if (_loggedInUser.Password == _view.OldPassword)
            {
                // Sprawdzenie, czy nowe hasła są identyczne
                if (_view.NewPassword != _view.ConfirmPassword)
                {
                    _view.ShowMessage("Nowe hasła muszą być identyczne.");
                    return;
                }

                // Walidacja nowego hasła
                if (!IsValidPassword(_view.NewPassword))
                {
                    _view.ShowMessage("Hasło musi mieć co najmniej 8 znaków, zawierać co najmniej jedną cyfrę i jeden znak specjalny.");
                    return;
                }

                // Aktualizacja hasła
                _loggedInUser.Password = _view.NewPassword;
                _context.Users.Update(_loggedInUser);
                _context.SaveChanges();

                _view.ShowMessage("Pomyślnie zmieniono hasło.");
                _view.Close();
            }
            else
            {
                _view.ShowMessage("Stare hasło jest nieprawidłowe.");
            }
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

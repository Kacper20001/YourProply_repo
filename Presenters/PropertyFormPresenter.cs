using System;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class PropertyFormPresenter
    {
        private readonly IPropertyFormView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;

        public PropertyFormPresenter(IPropertyFormView view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.SaveClick += OnSaveClick;
            _view.CloseClick += OnCloseClick;
        }

        /// <summary>
        /// Metoda obsługująca zapisanie nieruchomości.
        /// </summary>
        private void OnSaveClick(object sender, EventArgs e)
        {
            var property = _view.Property;
            var address = _view.Address;

            if (property != null && address != null)
            {
                try
                {
                    property.Address = address;
                    property.UserId = _loggedInUser.UserId;
                    if (property.PropertyId == 0)
                    {
                        _context.Properties.Add(property);
                    }
                    else
                    {
                        _context.Properties.Update(property);
                    }
                    _context.SaveChanges();
                    _view.ShowMessage("Nieruchomość zapisana pomyślnie.");
                    _view.Close();
                }
                catch (Exception ex)
                {
                    _view.ShowMessage($"Błąd podczas zapisywania nieruchomości: {ex.Message}");
                }
            }
            else
            {
                _view.ShowMessage("Proszę uzupełnić wszystkie pola.");
            }
        }

        /// <summary>
        /// Metoda obsługująca zamknięcie formularza.
        /// </summary>
        private void OnCloseClick(object sender, EventArgs e)
        {
            _view.Close();
        }
    }
}

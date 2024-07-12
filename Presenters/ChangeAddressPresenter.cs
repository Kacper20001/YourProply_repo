using System;
using System.Linq;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class ChangeAddressPresenter
    {
        private readonly IChangeAddressView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;

        public ChangeAddressPresenter(IChangeAddressView view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.SaveClick += OnSaveClick;
        }

        /// <summary>
        /// Metoda obsługująca zdarzenie zapisu zmiany adresu.
        /// </summary>
        private void OnSaveClick(object sender, EventArgs e)
        {
            var updatedAddress = _view.UpdatedAddress;

            if (updatedAddress != null)
            {
                var existingAddress = _context.Addresses.FirstOrDefault(a => a.AddressId == updatedAddress.AddressId);

                if (existingAddress != null)
                {
                    existingAddress.Street = updatedAddress.Street;
                    existingAddress.Number = updatedAddress.Number;
                    existingAddress.City = updatedAddress.City;
                    existingAddress.PostalCode = updatedAddress.PostalCode;
                    existingAddress.Province = updatedAddress.Province;
                    existingAddress.State = updatedAddress.State;

                    _context.Addresses.Update(existingAddress);
                    _context.SaveChanges();
                    _view.ShowMessage("Zapisano pomyślnie");
                    _view.Close();
                }
                else
                {
                    _view.ShowMessage("Nie znaleziono adresu.");
                }
            }
            else
            {
                _view.ShowMessage("Proszę uzupełnić wymagane pola.");
            }
        }
    }
}

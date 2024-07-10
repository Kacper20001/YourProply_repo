using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    _view.ShowMessage("Address updated successfully.");
                    _view.Close();
                }
                else
                {
                    _view.ShowMessage("Address not found.");
                }
            }
            else
            {
                _view.ShowMessage("Please fill in all required fields.");
            }
        }
    }
}

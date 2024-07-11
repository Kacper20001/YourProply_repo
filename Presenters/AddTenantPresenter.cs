using System;
using System.Linq;
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

        private void OnAddTenantClick(object sender, EventArgs e)
        {
            var existingUser = _context.Users
                .FirstOrDefault(u => u.UserName == _view.UserName || u.Email == _view.Email);

            if (existingUser != null && existingUser.UserId != _view.UserId)
            {
                _view.ShowMessage("User with this username or email already exists.");
                return;
            }

            var selectedProperty = _context.Properties.FirstOrDefault(p => p.PropertyId == _view.SelectedPropertyId);
            if (selectedProperty == null)
            {
                _view.ShowMessage("Selected property does not exist.");
                return;
            }

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

            _view.ShowMessage("Tenant added/updated successfully.");
            _view.Close();
        }
    }
}

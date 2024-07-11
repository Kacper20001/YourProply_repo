using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (existingUser != null)
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

            var address = new Address
            {
                Street = selectedProperty.Address.Street,
                Number = selectedProperty.Address.Number,
                City = selectedProperty.Address.City,
                PostalCode = selectedProperty.Address.PostalCode,
                Province = selectedProperty.Address.Province,
                State = selectedProperty.Address.State
            };

            var tenant = new Tenant
            {
                UserName = _view.UserName,
                FirstName = _view.FirstName,
                LastName = _view.LastName,
                Email = _view.Email,
                Password = _view.Password,
                Address = address,
                UserType = UserType.Tenant,
                DateOfBirth = _view.DateOfBirth,
                Property = selectedProperty,
                LandlordId = _loggedInUser.UserId

            };

            _context.Users.Add(tenant);
            _context.SaveChanges();

            _view.ShowMessage("Tenant added successfully.");
            _view.Close();

        }
    }
}

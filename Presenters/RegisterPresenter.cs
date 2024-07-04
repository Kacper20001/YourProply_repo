using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Views;
using System.Linq;


namespace YourProply.Presenters
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly YourProplyDbContext _context; 


        public RegisterPresenter(IRegisterView view, YourProplyDbContext context)
        {
            _view = view;
            _context = context;
            _view.Register += OnRegister;
         }
        private void OnRegister(object sender, EventArgs e)
        {
            if (_view.Password != _view.ConfirmPassword)
            {
                _view.ShowMessage("Passwords do not match.");
                return;
            }

            var existingUser = _context.Users
                .FirstOrDefault(u => u.UserName == _view.UserName || u.Email == _view.Email);

            if (existingUser != null)
            {
                _view.ShowMessage("User with this username or email already exists.");
                return;
            }
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

            var landlord = new Landlord
            {
                UserName = _view.UserName,
                FirstName = _view.FirstName,
                LastName = _view.LastName,
                Email = _view.Email,
                Password = _view.Password,
                Address = address,
                UserType = UserType.Landlord
            };
            _context.Users.Add(landlord);
            _context.SaveChanges();

            _view.ShowMessage("Registration successful!");
        }
    }
}

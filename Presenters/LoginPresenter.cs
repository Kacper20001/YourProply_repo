using System;
using System.Linq;
using YourProply.Entities;
using YourProply.Views;
using YourProply;

namespace YourProply.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly YourProplyDbContext _context;

        public LoginPresenter(ILoginView view, YourProplyDbContext context)
        {
            _view = view;
            _context = context;
            _view.LoginEvent += OnLogin;
            _view.RegisterClick += OnRegisterClick;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == _view.UserName && u.Password == _view.Password);

            if (user == null)
            {
                _view.ShowMessage("Invalid username or password.");
                return;
            }

            if (user.UserType == UserType.Landlord)
            {
                var landlordMenu = new LandlordMenu(user);
                var landlordMenuPresenter = new LandlordMenuPresenter(landlordMenu, _context, user);
                _view.Hide();
                landlordMenu.FormClosed += (s, args) => _view.Show();
                landlordMenu.Show();
            }
            else if (user.UserType == UserType.Tenant)
            {
                var tenantMenu = new TenantMenu(user);
                var tenantMenuPresenter = new TenantMenuPresenter(tenantMenu, _context, user);
                _view.Hide();
                tenantMenu.FormClosed += (s, args) => _view.Show();
                tenantMenu.Show();
            }
        }

        private void OnRegisterClick(object sender, EventArgs e)
        {
            var registerView = new RegisterLandlordForm();
            var registerPresenter = new RegisterPresenter(registerView, _context);
            _view.Hide();
            registerView.FormClosed += (s, args) => _view.Show();
            registerView.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Views;

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
        }
        private void OnLogin(object sender, EventArgs e)
        {
            var user = _context.Users
                .OfType<Landlord>()
                .FirstOrDefault(u => u.UserName == _view.UserName && u.Password == _view.Password);

            if (user != null)
            {
                _view.ShowMessage("Login successful!");
                // Można dodać logikę przekierowania do głównego widoku aplikacji
            }
            else
            {
                _view.ShowMessage("Invalid username or password.");
            }
        }
    }
}

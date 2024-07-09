using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class LandlordMenuPresenter
    {
        private readonly ILandlordMenu _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser; // Zalogowany użytkownik

        public LandlordMenuPresenter(ILandlordMenu view, YourProplyDbContext context, User loggedInUser) // Przekazanie użytkownika
        {
            _view = view;
            _context = context;
            _view.YourPropertiesClick += ShowPropertiesView;
            _view.YourAccountClick += ShowAccountView;
            _loggedInUser = loggedInUser; // Przypisanie użytkownika
        }
        private void ShowPropertiesView(object sender, EventArgs e)
        {
            var propertiesView = new PropertiesView(_loggedInUser);
            var propertiesPresenter = new PropertiesPresenter(propertiesView, _context, _loggedInUser);
            _view.Hide();
            propertiesView.FormClosed += (s, args) => _view.Show();
            propertiesView.Show();
        }
        private void ShowAccountView(object sender, EventArgs e)
        {
            var accountView = new LandlordAccountView(_view.LoggedInUser);
            accountView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            accountView.Show(); 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class LandlordAccountPresenter
    {
        private readonly ILandlordAccountView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser; 

        public LandlordAccountPresenter(ILandlordAccountView view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.ChangePasswordClick += OnChangePasswordClick;
            _view.ChangeAddressClick += OnChangeAddressClick;
        }

        private void OnChangePasswordClick(object sender, EventArgs e)
        {
            var changePasswordView = new ChangePasswordView(_loggedInUser);
            var changePasswordPresenter = new ChangePasswordPresenter(changePasswordView, _context, _loggedInUser);
            changePasswordView.ShowDialog();
        }

        private void OnChangeAddressClick(object sender, EventArgs e)
        {
            var changeAddressView = new ChangeAddressView(_loggedInUser);
            var changeAddressPresenter = new ChangeAddressPresenter(changeAddressView, _context, _loggedInUser);
            changeAddressView.ShowDialog();
        }
    }
}

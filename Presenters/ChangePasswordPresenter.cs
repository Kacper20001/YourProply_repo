using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class ChangePasswordPresenter
    {
        private readonly IChangePasswordView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;
        public ChangePasswordPresenter(IChangePasswordView view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.SaveClick += OnSaveClick;
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            if (_loggedInUser.Password == _view.OldPassword)
            {
                if (_view.NewPassword != _view.ConfirmPassword)
                {
                    _view.ShowMessage("Nowe hasła muszą być identyczne.");
                    return;
                }

                _loggedInUser.Password = _view.NewPassword;
                _context.Users.Update(_loggedInUser);
                _context.SaveChanges();

                _view.ShowMessage("Pomyślnie zmieniono hasło.");
                _view.Close();
            }
            else
            {
                _view.ShowMessage("Stare hasło jest nieprawidłowe.");
            }
        }
    }
}

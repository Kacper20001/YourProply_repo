using System;
using System.Linq;
using YourProply.Entities;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class LandlordAccountPresenter
    {
        private readonly ILandlordAccountView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;
        private readonly OpenAIService _openAIService;

        public LandlordAccountPresenter(ILandlordAccountView view, YourProplyDbContext context, User loggedInUser, OpenAIService openAIService)
        {
            _view = view;
            _openAIService = openAIService;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.ChangePasswordClick += OnChangePasswordClick;
            _view.ChangeAddressClick += OnChangeAddressClick;
            _view.BackToMenuClick += OnBackToMenuClick;
        }

        /// <summary>
        /// Metoda obsługująca zmianę hasła.
        /// </summary>
        private void OnChangePasswordClick(object sender, EventArgs e)
        {
            var changePasswordView = new ChangePasswordView(_loggedInUser);
            var changePasswordPresenter = new ChangePasswordPresenter(changePasswordView, _context, _loggedInUser);
            changePasswordView.ShowDialog();
        }

        /// <summary>
        /// Metoda obsługująca zmianę adresu.
        /// </summary>
        private void OnChangeAddressClick(object sender, EventArgs e)
        {
            var changeAddressView = new ChangeAddressView(_loggedInUser);
            var changeAddressPresenter = new ChangeAddressPresenter(changeAddressView, _context, _loggedInUser);
            changeAddressView.ShowDialog();
        }

        /// <summary>
        /// Metoda obsługująca powrót do menu.
        /// </summary>
        private void OnBackToMenuClick(object sender, EventArgs e)
        {
            var landlordMenu = new LandlordMenu(_loggedInUser);
            var landlordMenuPresenter = new LandlordMenuPresenter(landlordMenu, _context, _loggedInUser, _openAIService);
            _view.Hide();
            landlordMenu.FormClosed += (s, args) => _view.Show();
            landlordMenu.Show();
        }
    }
}

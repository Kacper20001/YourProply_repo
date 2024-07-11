﻿using System;
using System.Linq;
using YourProply.Entities;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly YourProplyDbContext _context;
        private readonly OpenAIService _openAIService;

        public RegisterPresenter(IRegisterView view, YourProplyDbContext context, OpenAIService openAIService)
        {
            _openAIService = openAIService;
            _view = view;
            _context = context;
            _view.Register += OnRegister;
            _view.AlreadyHaveAccountClick += OnAlreadyHaveAccountClick;
        }

        private void OnRegister(object sender, EventArgs e)
        {
            if (_view.Password != _view.ConfirmPassword)
            {
                _view.ShowMessage("Hasła nie są identyczne");
                return;
            }

            var existingUser = _context.Users
                .FirstOrDefault(u => u.UserName == _view.UserName || u.Email == _view.Email);

            if (existingUser != null)
            {
                _view.ShowMessage("Użytkownik o podanej nazwie lub adresie email już istnieje.");
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
                UserType = UserType.Landlord,
                DateOfBirth = _view.DateOfBirth
            };

            _context.Users.Add(landlord);
            _context.SaveChanges();

            _view.ShowMessage("Zarejestrowano!");
            _view.ClearForm();
            _view.Hide();
            var loginView = new Login();
            var loginPresenter = new LoginPresenter(loginView, _context, _openAIService);
            //loginView.FormClosed += (s, args) => _view.Show();
            loginView.ShowDialog();
            _view.Close();
        }

        private void OnAlreadyHaveAccountClick(object sender, EventArgs e)
        {
            var loginView = new Login();
            var loginPresenter = new LoginPresenter(loginView, _context, _openAIService);
            _view.Hide();
            loginView.FormClosed += (s, args) => _view.Show();
            loginView.ShowDialog();

        }
    }
}

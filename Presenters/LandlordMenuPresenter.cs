﻿using System;
using System.Linq;
using YourProply.Entities;
using YourProply.PDF;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class LandlordMenuPresenter
    {
        private readonly ILandlordMenu _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;
        private readonly OpenAIService _openAIService;

        public LandlordMenuPresenter(ILandlordMenu view, YourProplyDbContext context, User loggedInUser, OpenAIService openAIService)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser ?? throw new ArgumentNullException(nameof(loggedInUser));
            _openAIService = openAIService;
            _view.YourPropertiesClick += ShowPropertiesView;
            _view.YourAccountClick += ShowAccountView;
            _view.GenerateLeaseAgreementClick += btnGenerateLeaseAgreement_Click;
            _view.SendEmailClick += ShowSendEmailView;
            _view.OpenChatbotClick += ShowChatbotView;
            _view.LogoutClick += Logout;
            _view.ManageUsersClick += ShowUsersView;
        }

        /// <summary>
        /// Metoda pokazująca widok nieruchomości.
        /// </summary>
        private void ShowPropertiesView(object sender, EventArgs e)
        {
            var propertiesView = new PropertiesView(_loggedInUser);
            var propertiesPresenter = new PropertiesPresenter(propertiesView, _context, _loggedInUser, _openAIService);
            _view.Hide();
            propertiesView.FormClosed += (s, args) => _view.Show();
            propertiesView.Show();
        }

        /// <summary>
        /// Metoda pokazująca widok użytkowników.
        /// </summary>
        private void ShowUsersView(object sender, EventArgs e)
        {
            var usersView = new UsersView(_loggedInUser);
            var usersPresenter = new UsersPresenter(usersView, _context, _loggedInUser, _openAIService);
            _view.Hide();
            usersView.FormClosed += (s, args) => _view.Show();
            usersView.Show();
        }

        /// <summary>
        /// Metoda pokazująca widok konta.
        /// </summary>
        private void ShowAccountView(object sender, EventArgs e)
        {
            var accountView = new LandlordAccountView(_loggedInUser, _context);
            var accountPresenter = new LandlordAccountPresenter(accountView, _context, _loggedInUser, _openAIService);
            accountView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            accountView.Show();
        }

        /// <summary>
        /// Metoda pokazująca widok genrowania umowy najmu.
        /// </summary>
        private void btnGenerateLeaseAgreement_Click(object sender, EventArgs e)
        {
            var generateLeaseAgreementView = new GenerateLeaseAgreementForm();
            var generateLeaseAgreementPresenter = new GenerateLeaseAgreementPresenter(generateLeaseAgreementView, _context, _loggedInUser, _openAIService);
            generateLeaseAgreementView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            generateLeaseAgreementView.Show();
        }

        /// <summary>
        /// Metoda pokazująca widok wysyłania emaili.
        /// </summary>
        private void ShowSendEmailView(object sender, EventArgs e)
        {
            var tenants = _context.Users.OfType<Tenant>().Where(t => t.LandlordId == _loggedInUser.UserId).ToList();
            var emailService = new EmailService("smtp-mail.outlook.com", 587, _loggedInUser.Email, _loggedInUser.Password);
            Console.WriteLine($"Email: {_loggedInUser.Email}, Password: {_loggedInUser.Password}");
            var sendEmailView = new SendEmailView(tenants);
            var sendEmailPresenter = new SendEmailPresenter(sendEmailView, emailService, _loggedInUser, tenants, _context, _openAIService);
            sendEmailView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            sendEmailView.Show();
        }

        /// <summary>
        /// Metoda pokazująca widok chatbota.
        /// </summary>
        private void ShowChatbotView(object sender, EventArgs e)
        {
            var chatbotView = new ChatbotView();
            var chatbotPresenter = new ChatbotPresenter(chatbotView, _openAIService, _context, _loggedInUser);
            chatbotView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            chatbotView.Show();
        }

        /// <summary>
        /// Metoda wylogowująca użytkownika.
        /// </summary>
        private void Logout(object sender, EventArgs e)
        {
            var loginView = new Login();
            var loginPresenter = new LoginPresenter(loginView, _context, _openAIService);
            _view.Hide();
            loginView.FormClosed += (s, args) => _view.Show();
            loginView.Show();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Models;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class SendEmailPresenter
    {
        private readonly ISendEmailView _view;
        private readonly EmailService _emailService;
        private readonly User _loggedInUser;
        private readonly YourProplyDbContext _context;
        private readonly OpenAIService _openAIService;

        public SendEmailPresenter(ISendEmailView view, EmailService emailService, User loggedInUser, List<Tenant> tenants, YourProplyDbContext context, OpenAIService openAIService)
        {
            _view = view;
            _openAIService = openAIService;
            _context = context;
            _emailService = emailService;
            _loggedInUser = loggedInUser;
            _view.SetTenants(tenants);
            _view.SendEmailClick += OnSendEmailClick;
            _view.BackToMenuClick += OnBackToMenuClick;
        }
        /// <summary>
        /// Metoda obsługująca wysyłanie emaila.
        /// </summary>
        private async void OnSendEmailClick(object sender, EventArgs e)
        {
            var tenant = _view.SelectedTenant;
            if (tenant == null)
            {
                _view.ShowMessage("Proszę wybrać najemcę.");
                return;
            }

            var email = new EmailMessage
            {
                To = tenant.Email,
                Subject = _view.Subject,
                Body = _view.Body
            };
            try
            {
                await _emailService.SendEmailAsync(email.To, email.Subject, email.Body);
                _view.ShowMessage("Email wysłany pomyślnie");
                _view.ClearForm();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Błąd: {ex.Message}");
            }
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

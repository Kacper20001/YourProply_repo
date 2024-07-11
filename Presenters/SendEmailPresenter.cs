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

        public SendEmailPresenter(ISendEmailView view, EmailService emailService, User loggedInUser, List<Tenant> tenants)
        {
            _view = view;
            _emailService = emailService;
            _loggedInUser = loggedInUser;
            _view.SetTenants(tenants);
            _view.SendEmailClick += OnSendEmailClick;
        }

        private async void OnSendEmailClick(object sender, EventArgs e)
        {
            var tenant = _view.SelectedTenant;
            if (tenant == null)
            {
                _view.ShowMessage("Please select a tenant.");
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
                _view.ShowMessage("Email sent successfully.");
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error sending email: {ex.Message}");
                _view.ClearForm();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
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
            _view.AddTenantClick += ShowAddTenantView;
            _view.GenerateLeaseAgreementClick += btnGenerateLeaseAgreement_Click;
            _view.SendEmailClick += ShowSendEmailView;
            _view.OpenChatbotClick += ShowChatbotView;
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
            var accountView = new LandlordAccountView(_loggedInUser, _context);
            var accountPresenter = new LandlordAccountPresenter(accountView, _context, _loggedInUser);
            accountView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            accountView.Show();
        }

        private void ShowAddTenantView(object sender, EventArgs e)
        {
            var availableProperties = _context.Properties
                .Include(p => p.Address)
                .Where(p => p.UserId == _loggedInUser.UserId).ToList();
            var addTenantView = new AddTenantView(availableProperties);
            var addTenantPresenter = new AddTenantPresenter(addTenantView, _context, _loggedInUser);
            addTenantView.FormClosed += (s, args) => _view.Show();
            addTenantView.Show();
        }

        private void btnGenerateLeaseAgreement_Click(object sender, EventArgs e)
        {
            var generateLeaseAgreementView = new GenerateLeaseAgreementForm();
            generateLeaseAgreementView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            generateLeaseAgreementView.Show();
        }

        private void ShowSendEmailView(object sender, EventArgs e)
        {
            var tenants = _context.Users.OfType<Tenant>().Where(t => t.LandlordId == _loggedInUser.UserId).ToList();
            var emailService = new EmailService("smtp-mail.outlook.com", 587, _loggedInUser.Email, _loggedInUser.Password);
            Console.WriteLine($"Email: {_loggedInUser.Email}, Password: {_loggedInUser.Password}");
            var sendEmailView = new SendEmailView(tenants);
            var sendEmailPresenter = new SendEmailPresenter(sendEmailView, emailService, _loggedInUser, tenants);
            sendEmailView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            sendEmailView.Show();
        }
        private void ShowChatbotView(object sender, EventArgs e)
        {
            var chatbotView = new ChatbotView();
            var chatbotPresenter = new ChatbotPresenter(chatbotView, _openAIService);
            chatbotView.FormClosed += (s, args) => _view.Show();
            _view.Hide();
            chatbotView.Show();
        }
    }
}

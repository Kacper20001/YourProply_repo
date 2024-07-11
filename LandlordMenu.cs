using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply
{
    public partial class LandlordMenu : Form, ILandlordMenu
    {
        private readonly User _loggedInUser;

        public LandlordMenu(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
            btnYourProperties.Click += (s, e) => YourPropertiesClick?.Invoke(this, EventArgs.Empty);
            btnYourAccount.Click += (s, e) => YourAccountClick?.Invoke(this, EventArgs.Empty);
            btnAddTenant.Click += (s, e) => AddTenantClick?.Invoke(this, EventArgs.Empty);
            btnGenerateLeaseAgreement.Click += (s, e) => GenerateLeaseAgreementClick?.Invoke(this, EventArgs.Empty);
            btnSendEmail.Click += (s, e) => SendEmailClick?.Invoke(this, EventArgs.Empty);
            btnChatAI.Click += (s, e) => OpenChatbotClick?.Invoke(this, EventArgs.Empty);
            btnLogout.Click += (s, e) => LogoutClick?.Invoke(this, EventArgs.Empty); 


        }

        public event EventHandler YourPropertiesClick;
        public event EventHandler YourAccountClick;
        public event EventHandler AddTenantClick;
        public event EventHandler GenerateLeaseAgreementClick;
        public event EventHandler SendEmailClick;
        public event EventHandler OpenChatbotClick;
        public event EventHandler LogoutClick;
        public User LoggedInUser => _loggedInUser;

        public new void Hide()
        {
            base.Hide();
        }

        public new void Show()
        {
            base.Show();
        }

        private void ntnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateLeaseAgreement_Click(object sender, EventArgs e)
        {

        }
    }
}
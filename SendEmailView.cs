using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply
{
    public partial class SendEmailView : Form, ISendEmailView
    {
        public event EventHandler SendEmailClick;
        public event EventHandler BackToMenuClick;

        public SendEmailView(List<Tenant> tenants)
        {
            InitializeComponent();
            SetTenants(tenants);
            btnSendEmail.Click += (s, e) => SendEmailClick?.Invoke(this, EventArgs.Empty);
            btnBack.Click += (s, e) => BackToMenuClick?.Invoke(this, EventArgs.Empty);
        }

        public Tenant SelectedTenant => (Tenant)cmbTenants.SelectedItem;
        public string Subject => txtSubject.Text;
        public string Body => txtBody.Text;

        public void SetTenants(List<Tenant> tenants)
        {
            cmbTenants.DataSource = tenants;
            cmbTenants.DisplayMember = "Email";
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public new void Show()
        {
            base.Show();
        }

        public new void Hide()
        {
            base.Hide();
        }

        public new void Close()
        {
            base.Close();
        }
        public void ClearForm()
        {
            cmbTenants.SelectedIndex = -1;
            txtSubject.Clear();
            txtBody.Clear();
        }
    }
}

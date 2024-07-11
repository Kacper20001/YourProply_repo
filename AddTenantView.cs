using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply
{
    public partial class AddTenantView : Form, IAddTenantView
    {
        private readonly List<Property> _availableProperties;
        private readonly Tenant _tenant;

        public AddTenantView(List<Property> availableProperties, Tenant tenant = null)
        {
            InitializeComponent();
            _availableProperties = availableProperties;
            _tenant = tenant;
            btnAddTenant.Click += (s, e) => AddTenantClick?.Invoke(this, EventArgs.Empty);
            LoadAvailableProperties();
            LoadTenantData();
        }

        public event EventHandler AddTenantClick;

        public int UserId => _tenant?.UserId ?? 0;
        public string UserName => txtUserName.Text;
        public string FirstName => txtFirstName.Text;
        public string LastName => txtLastName.Text;
        public DateTime DateOfBirth => dtpBirthDate.Value;
        public string IdNumber => txtIdNumber.Text;
        public string Email => txtEmail.Text;
        public string Password => txtPassword.Text;
        public int SelectedPropertyId => (int)comboBoxProperties.SelectedValue;

        // Implement the new address properties
        public string Street => txtStreet.Text;
        public string HouseNumber => txtHouseNumber.Text;
        public string City => txtCity.Text;
        public string PostalCode => txtPostalCode.Text;
        public string Province => txtProvince.Text;
        public string State => txtState.Text;

        private void LoadAvailableProperties()
        {
            comboBoxProperties.DataSource = _availableProperties;
            comboBoxProperties.DisplayMember = "Name";
            comboBoxProperties.ValueMember = "PropertyId";
        }

        private void LoadTenantData()
        {
            if (_tenant != null)
            {
                txtUserName.Text = _tenant.UserName;
                txtFirstName.Text = _tenant.FirstName;
                txtLastName.Text = _tenant.LastName;
                dtpBirthDate.Value = _tenant.DateOfBirth;
                txtIdNumber.Text = _tenant.IdNumber.ToString();
                txtEmail.Text = _tenant.Email;
                txtPassword.Text = _tenant.Password;
                comboBoxProperties.SelectedValue = _tenant.Property?.PropertyId ?? 0;

                // Load address data
                txtStreet.Text = _tenant.Address?.Street ?? string.Empty;
                txtHouseNumber.Text = _tenant.Address?.Number ?? string.Empty;
                txtCity.Text = _tenant.Address?.City ?? string.Empty;
                txtPostalCode.Text = _tenant.Address?.PostalCode ?? string.Empty;
                txtProvince.Text = _tenant.Address?.Province ?? string.Empty;
                txtState.Text = _tenant.Address?.State ?? string.Empty;
            }
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
    }
}

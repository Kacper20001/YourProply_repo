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
    public partial class AddTenantView : Form, IAddTenantView
    {
        private readonly List<Property> _availableProperties;

        public AddTenantView(List<Property> availableProperties)
        {
            InitializeComponent();
            _availableProperties = availableProperties;
            btnAddTenant.Click += (s, e) => AddTenantClick?.Invoke(this, EventArgs.Empty);
            LoadAvailableProperties();
        }

        public event EventHandler AddTenantClick;

        public string UserName => txtUserName.Text;
        public string FirstName => txtFirstName.Text;
        public string LastName => txtLastName.Text;
        public DateTime DateOfBirth => dtpBirthDate.Value;
        public string IdNumber => txtIdNumber.Text;
        public string Email => txtEmail.Text;
        public string Password => txtPassword.Text;
        public int SelectedPropertyId => (int)comboBoxProperties.SelectedValue;

        private void LoadAvailableProperties()
        {
            comboBoxProperties.DataSource = _availableProperties;
            comboBoxProperties.DisplayMember = "Name";
            comboBoxProperties.ValueMember = "PropertyId";
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

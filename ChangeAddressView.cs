using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourProply.Views;
using YourProply.Entities;

namespace YourProply
{
    public partial class ChangeAddressView : Form, IChangeAddressView
    {
        private readonly User _loggedInUser;

        public event EventHandler SaveClick;

        public ChangeAddressView(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
            LoadAddressData();
            btnSave.Click += (s, e) => SaveClick?.Invoke(this, EventArgs.Empty);
        }
        private void LoadAddressData()
        {
            txtStreet.Text = _loggedInUser.Address.Street;
            txtHouseNumber.Text = _loggedInUser.Address.Number;
            txtCity.Text = _loggedInUser.Address.City;
            txtPostalCode.Text = _loggedInUser.Address.PostalCode;
            txtProvince.Text = _loggedInUser.Address.Province;
            txtState.Text = _loggedInUser.Address.State;
        }
        public Address UpdatedAddress
        {
            get
            {
                return new Address
                {
                    AddressId = _loggedInUser.Address.AddressId,
                    Street = txtStreet.Text,
                    Number = txtHouseNumber.Text,
                    City = txtCity.Text,
                    PostalCode = txtPostalCode.Text,
                    Province = txtProvince.Text,
                    State = txtState.Text
                };
            }
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public new void Close()
        {
            base.Close();
        }
    }
}

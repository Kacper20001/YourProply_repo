using Microsoft.EntityFrameworkCore;
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
    public partial class LandlordAccountView : Form, ILandlordAccountView
    {
        private readonly User _loggedInUser;
        private readonly YourProplyDbContext _context;

        public LandlordAccountView(User user, YourProplyDbContext context)
        {
            InitializeComponent();
            _loggedInUser = user ?? throw new ArgumentNullException(nameof(user));
            _context = context;
            btnChangeAddress.Click += (s, e) => ChangeAddressClick?.Invoke(this, EventArgs.Empty);
            btnChangePassword.Click += (s, e) => ChangePasswordClick?.Invoke(this, EventArgs.Empty);
            btnBack.Click += (s, e) => BackToMenuClick?.Invoke(this, EventArgs.Empty);
            LoadUserData();
        }
        public event EventHandler ChangePasswordClick; 
        public event EventHandler ChangeAddressClick;
        public event EventHandler BackToMenuClick;


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

        public void LoadUserData()
        {
            var user = _context.Users.Include(u => u.Address).FirstOrDefault(u => u.UserId == _loggedInUser.UserId);
            if (user == null)
            {
                ShowMessage("User not found.");
                return;
            }

            txtUserName.Text = user.UserName;
            txtEmail.Text = user.Email;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtBirthday.Text = user.DateOfBirth.ToString("dd.MM.yyyy");
            txtIdNumber.Text = user.IdNumber.ToString();

            if (user.Address != null)
            {
                txtStreet.Text = user.Address.Street;
                txtHouseNumber.Text = user.Address.Number;
                txtCity.Text = user.Address.City;
                txtPostalCode.Text = user.Address.PostalCode;
                txtProvince.Text = user.Address.Province;
                txtState.Text = user.Address.State;
            }
            else
            {
                txtStreet.Text = string.Empty;
                txtHouseNumber.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtPostalCode.Text = string.Empty;
                txtProvince.Text = string.Empty;
                txtState.Text = string.Empty;
            }
        }

    }
}

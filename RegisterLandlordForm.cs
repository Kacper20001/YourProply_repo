using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YourProply.Views;

namespace YourProply
{
    public partial class RegisterLandlordForm : Form, IRegisterView
    {
        public RegisterLandlordForm()
        {
            InitializeComponent();
            btnRegister.Click += (s, e) => Register?.Invoke(this, EventArgs.Empty);
            LoginBtn.Click += (s, e) => AlreadyHaveAccountClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Register;
        public event EventHandler AlreadyHaveAccountClick;

        public string UserName => txtUserName.Text;
        public string FirstName => txtFirstName.Text;
        public string LastName => txtLastName.Text;
        public DateTime DateOfBirth => dtpBirthDate.Value;
        public string IdNumber => txtIdNumber.Text;
        public string Email => txtEmail.Text;
        public string Password => txtPassword.Text;
        public string ConfirmPassword => txtConfirmPassword.Text;
        public string Street => txtStreet.Text;
        public string Number => txtHouseNumber.Text;
        public string City => txtCity.Text;
        public string PostalCode => txtPostalCode.Text;
        public string Province => txtProvince.Text;
        public string State => txtState.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearForm()
        {
            txtUserName.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtIdNumber.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtStreet.Clear();
            txtHouseNumber.Clear();
            txtCity.Clear();
            txtPostalCode.Clear();
            txtProvince.Clear();
            txtState.Clear();
            dtpBirthDate.Value = DateTime.Now;
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

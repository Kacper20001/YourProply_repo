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

namespace YourProply
{
    public partial class RegisterLandlordForm : Form, IRegisterView
    {
        public RegisterLandlordForm()
        {
            InitializeComponent();
            btnRegister.Click += (s, e) => Register?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Register;
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



        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login start = new Login();
            start.Show();
        }

        
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text) ||
                string.IsNullOrWhiteSpace(txtHouseNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtPostalCode.Text) ||
                string.IsNullOrWhiteSpace(txtProvince.Text) ||
                string.IsNullOrWhiteSpace(txtState.Text) ||
                !int.TryParse(txtIdNumber.Text, out _))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola poprawnie.");
                return false;
            }
            DateTime birthDate = dtpBirthDate.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("Użytkownik musi być pełnoletni (co najmniej 18 lat).");
                return false;
            }

            return true;
        }
        private void ClearForm()
        {
            txtUserName.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            txtIdNumber.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtStreet.Text = "";
            txtHouseNumber.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
            txtProvince.Text = "";
            txtState.Text = "";
        }
    }
}

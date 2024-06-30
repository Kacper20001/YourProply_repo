using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourProply
{
    public partial class RegisterLandlordForm : Form
    {
        public RegisterLandlordForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

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

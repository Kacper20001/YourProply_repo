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

namespace YourProply
{
    public partial class NewPropertyForm : Form
    {
        public NewPropertyForm()
        {
            InitializeComponent();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    using (var context = new YourProplyDbContext())
                    {
                        var address = new Address
                        {
                            Street = txtStreet.Text,
                            Number = txtNumber.Text,
                            City = txtCity.Text,
                            PostalCode = txtPostalCode.Text,
                            Province = txtProvince.Text,
                            State = txtState.Text
                        };

                        var property = new Property(0, txtName.Text, txtDescription.Text, address,
                            txtAvailability.Text.ToLower() == "tak", txtType.Text, double.Parse(txtArea.Text), int.Parse(txtRooms.Text));

                        context.Properties.Add(property);
                        context.SaveChanges();

                        MessageBox.Show("Nieruchomość została dodana pomyślnie.");
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas dodawania nieruchomości: {ex.Message}");
                }
            }
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text) ||
                string.IsNullOrWhiteSpace(txtRooms.Text) ||
                string.IsNullOrWhiteSpace(txtArea.Text) ||
                string.IsNullOrWhiteSpace(txtAvailability.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text) ||
                string.IsNullOrWhiteSpace(txtNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtPostalCode.Text) ||
                string.IsNullOrWhiteSpace(txtProvince.Text) ||
                string.IsNullOrWhiteSpace(txtState.Text))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola poprawnie.");
                return false;
            }

            if (!double.TryParse(txtArea.Text, out _) || !int.TryParse(txtRooms.Text, out _))
            {
                MessageBox.Show("Powierzchnia i liczba pokoi muszą być liczbami.");
                return false;
            }

            return true;
        }
        private void ClearForm()
        {
            txtName.Text = "";
            txtType.Text = "";
            txtRooms.Text = "";
            txtArea.Text = "";
            txtAvailability.Text = "";
            txtStreet.Text = "";
            txtNumber.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
            txtProvince.Text = "";
            txtState.Text = "";
            txtDescription.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

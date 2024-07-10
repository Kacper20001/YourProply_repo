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
    public partial class PropertyForm : Form, IPropertyFormView
    {
        public event EventHandler SaveClick;
        private Property _property;
        private Address _address;

        public PropertyForm(Property property = null)
        {
            InitializeComponent();
            _property = property ?? new Property();
            _address = _property.Address ?? new Address();
            btnSave.Click += (s, e) => SaveClick?.Invoke(this, EventArgs.Empty);
            LoadPropertyData();
        }
        private void LoadPropertyData()
        {
            if (_property != null)
            {
                txtPropertyName.Text = _property.Name;
                txtPropertyDescription.Text = _property.Description;
                txtArea.Text = _property.Area.ToString();
                comboBoxAvailability.SelectedItem = _property.IsAvailable ? "Yes" : "No";
                txtRooms.Text = _property.NumberOfRooms.ToString();
                txtStreet.Text = _address.Street;
                txtHouseNumber.Text = _address.Number;
                txtCity.Text = _address.City;
                txtPostalCode.Text = _address.PostalCode;
                txtProvince.Text = _address.Province;
                txtState.Text = _address.State;
                txtPropertyType.Text = _property.PropertyType; 
            }
        }
        public Property Property
        {
            get
            {
                _property.Name = txtPropertyName.Text;
                _property.Description = txtPropertyDescription.Text;
                _property.Area = double.TryParse(txtArea.Text, out double area) ? area : 0;
                _property.IsAvailable = comboBoxAvailability.SelectedItem != null && comboBoxAvailability.SelectedItem.ToString() == "Yes";
                _property.NumberOfRooms = int.TryParse(txtRooms.Text, out int rooms) ? rooms : 0;
                _property.PropertyType = txtPropertyType.Text;
                _property.Address = Address;
                return _property;
            }
            set
            {
                _property = value;
                LoadPropertyData();
            }
        }
        public Address Address
        {
            get
            {
                _address.Street = txtStreet.Text;
                _address.Number = txtHouseNumber.Text;
                _address.City = txtCity.Text;
                _address.PostalCode = txtPostalCode.Text;
                _address.Province = txtProvince.Text;
                _address.State = txtState.Text;
                return _address;
            }
            set
            {
                _address = value ?? new Address();
                if (_address != null)
                {
                    txtStreet.Text = _address.Street;
                    txtHouseNumber.Text = _address.Number;
                    txtCity.Text = _address.City;
                    txtPostalCode.Text = _address.PostalCode;
                    txtProvince.Text = _address.Province;
                    txtState.Text = _address.State;
                }
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

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
    public partial class PropertiesView : Form, IPropertiesView
    {

        public PropertiesView(User loggedInUser)
        {
            InitializeComponent();
            btnAddProperty.Click += (s, e) => AddPropertyClick?.Invoke(this, EventArgs.Empty);
            btnEditProperty.Click += (s, e) => EditPropertyClick?.Invoke(this, EventArgs.Empty);
            btnDeleteProperty.Click += (s, e) => DeletePropertyClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler AddPropertyClick;
        public event EventHandler EditPropertyClick;
        public event EventHandler DeletePropertyClick;
        public void SetProperties(List<Property> properties)
        {
            dataGridProperties.DataSource = properties;
        }
        public Property GetSelectedProperty()
        {
            return dataGridProperties.SelectedRows.Count == 1 ? dataGridProperties.SelectedRows[0].DataBoundItem as Property : null;
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

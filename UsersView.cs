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
    public partial class UsersView : Form, IUsersView
    {
        public UsersView(User loggedInUser)
        {
            InitializeComponent();
            btnAddUser.Click += (s, e) => AddUserClick?.Invoke(this, EventArgs.Empty);
            btnEditUser.Click += (s, e) => EditUserClick?.Invoke(this, EventArgs.Empty);
            btnDeleteUser.Click += (s, e) => DeleteUserClick?.Invoke(this, EventArgs.Empty);
            btnBack.Click += (s, e) => BackToMenuClick?.Invoke(this, EventArgs.Empty);
            txtFilter.TextChanged += (s, e) => FilterUsers?.Invoke(this, txtFilter.Text);
        }

        public event EventHandler AddUserClick;
        public event EventHandler EditUserClick;
        public event EventHandler DeleteUserClick;
        public event EventHandler<string> FilterUsers;
        public event EventHandler BackToMenuClick;

        public void SetUsers(List<Tenant> users)
        {
            dataGridUsers.DataSource = users;
        }

        public Tenant GetSelectedUser()
        {
            return dataGridUsers.SelectedRows.Count == 1 ? dataGridUsers.SelectedRows[0].DataBoundItem as Tenant : null;
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
    }
}

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
    public partial class ChangePasswordView : Form, IChangePasswordView
    {
        private readonly User _loggedInUser;

        public event EventHandler SaveClick;

        public ChangePasswordView(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
            btnSave.Click += (s, e) => SaveClick?.Invoke(this, EventArgs.Empty);
        }
        public string OldPassword => txtOldPassword.Text;
        public string NewPassword => txtNewPassword.Text;
        public string ConfirmPassword => txtConfirmNewPassword.Text;
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

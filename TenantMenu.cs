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
    public partial class TenantMenu : Form
    {
        private readonly User _loggedInUser;

        public TenantMenu(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        public User LoggedInUser => _loggedInUser;

        public new void Hide()
        {
            base.Hide();
        }

        public new void Show()
        {
            base.Show();
        }
    }
}

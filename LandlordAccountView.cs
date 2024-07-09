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
    public partial class LandlordAccountView : Form
    {
        private readonly User _loggedInUser;
        public LandlordAccountView(User user)
        {
            InitializeComponent();
            _loggedInUser = user;

        }
        private void Show()
        {
            base.Show();
        }
    }
}

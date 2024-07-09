﻿using System;
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
    public partial class LandlordMenu : Form, ILandlordMenu
    {
        private readonly User _loggedInUser;

        public LandlordMenu(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
            btnYourProperties.Click += (s, e) => YourPropertiesClick?.Invoke(this, EventArgs.Empty);
            btnYourAccount.Click += (s, e) => YourAccountClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler YourPropertiesClick;
        public event EventHandler YourAccountClick;
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
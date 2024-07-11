using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;

namespace YourProply.Views
{
    public interface ILandlordMenu
    {
        event EventHandler YourPropertiesClick;
        event EventHandler YourAccountClick;
        event EventHandler AddTenantClick;
        event EventHandler GenerateLeaseAgreementClick;
        event EventHandler SendEmailClick;
        event EventHandler OpenChatbotClick;
        event EventHandler LogoutClick;

        User LoggedInUser { get; }
        void Hide();
        void Show();
    }
}

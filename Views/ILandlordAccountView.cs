using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Views
{
    public interface ILandlordAccountView
    {
        event EventHandler ChangePasswordClick;
        event EventHandler ChangeAddressClick;
        event EventHandler BackToMenuClick;
        void ShowMessage(string message);
        void Show();
        void Close();
        void Hide();
    }
}

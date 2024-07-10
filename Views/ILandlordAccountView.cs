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
        void ShowMessage(string message);
        void Show();
        void Close();
        void Hide();
    }
}

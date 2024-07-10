using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Views
{
    public interface IChangePasswordView
    {
        event EventHandler SaveClick;

        string NewPassword { get; }
        string OldPassword { get; }
        string ConfirmPassword { get; }

        void ShowMessage(string message);
        void Close();
    }
}

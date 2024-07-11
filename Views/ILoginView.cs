using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Views
{
    public interface ILoginView
    {
        string UserName { get; }
        string Password { get; }

        event EventHandler LoginEvent;
        event EventHandler RegisterClick;
        event EventHandler CloseAppClick;

        void ShowMessage(string message);
        void Show();
        void Hide();
        void Close();
    }
}

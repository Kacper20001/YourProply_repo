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
        void ShowMessage(string message);
    }
}

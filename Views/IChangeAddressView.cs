using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;

namespace YourProply.Views
{
    public interface IChangeAddressView
    {
        event EventHandler SaveClick;
        Address UpdatedAddress { get; }

        void ShowMessage(string message);
        void Close();
    }
}

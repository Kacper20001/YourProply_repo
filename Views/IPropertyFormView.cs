using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;

namespace YourProply.Views
{
    public interface IPropertyFormView
    {
        event EventHandler SaveClick;
        event EventHandler CloseClick;
        Property Property { get; set; }
        Address Address { get; set; }

        void ShowMessage(string message);
        void Close();
    }
}

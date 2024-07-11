using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;

namespace YourProply.Views
{
    public interface IPropertiesView
    {
        event EventHandler AddPropertyClick;
        event EventHandler EditPropertyClick;
        event EventHandler DeletePropertyClick;
        event EventHandler<string> FilterProperties;
        event EventHandler BackToMenuClick; 



        void SetProperties(List<Property> properties);
        Property GetSelectedProperty();
        void ShowMessage(string message);
        void Show();
        void Hide();
    }
}

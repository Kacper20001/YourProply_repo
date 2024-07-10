using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class PropertyFormPresenter
    {
        private readonly IPropertyFormView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;

        public PropertyFormPresenter(IPropertyFormView view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.SaveClick += OnSaveClick;
        }
        private void OnSaveClick(object sender, EventArgs e)
        {
            var property = _view.Property;
            var address = _view.Address;
            if (property != null && address != null)
            {
                property.Address = address;
                property.UserId = _loggedInUser.UserId; // Przypisanie UserId
                if (property.PropertyId == 0)
                {
                    _context.Properties.Add(property);
                }
                else
                {
                    _context.Properties.Update(property);
                }
                    _context.SaveChanges();
                    _view.ShowMessage("Property saved successfully.");
                    _view.Close();
            }
            else
            {
                _view.ShowMessage("Please fill in all required fields.");
            }
        }
    }
}

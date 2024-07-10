using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class PropertiesPresenter
    {
        private readonly IPropertiesView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;

        public PropertiesPresenter(IPropertiesView view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.AddPropertyClick += OnAddPropertyClick;
            _view.EditPropertyClick += OnEditPropertyClick;
            _view.DeletePropertyClick += OnDeletePropertyClick;
            LoadProperties();
        }

        private void LoadProperties()
        {
            var properties = _context.Properties
               .Include(p => p.Address)
               .Where(p => p.UserId == _loggedInUser.UserId)
               .ToList();

            _view.SetProperties(properties);
        }
        private void OnAddPropertyClick(object sender, EventArgs e) 
        {
            var propertyForm = new PropertyForm();
            var propertyPresenter = new PropertyFormPresenter(propertyForm, _context, _loggedInUser);
            propertyForm.FormClosed += (s, args) => LoadProperties();
            propertyForm.ShowDialog();
        }
        private void OnEditPropertyClick(object sender, EventArgs e)
        {
            var selectedProperty = _view.GetSelectedProperty();
            if (selectedProperty != null)
            {
                var propertyForm = new PropertyForm(selectedProperty);
                var propertyPresenter = new PropertyFormPresenter(propertyForm, _context, _loggedInUser);
                propertyForm.FormClosed += (s, args) => LoadProperties();
                propertyForm.ShowDialog();
            }
            else
            {
                _view.ShowMessage("Wybierz nieruchomość, którą chcesz edytować");
            }
        }

        private void OnDeletePropertyClick(object sender, EventArgs e)
        {
            var selectedProperty = _view.GetSelectedProperty();
            if ( selectedProperty != null)
            {
                _context.Properties.Remove(selectedProperty);
                _context.SaveChanges();
                LoadProperties();
            }
            else
            {
                _view.ShowMessage("Wybierz nieruchomość, którą chcesz usunąć");
            }
        }


    }
}

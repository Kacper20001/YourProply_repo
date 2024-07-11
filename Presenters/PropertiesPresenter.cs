using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class PropertiesPresenter
    {
        private readonly IPropertiesView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;
        private List<Property> _allProperties;
        private readonly OpenAIService _openAIService;

        public PropertiesPresenter(IPropertiesView view, YourProplyDbContext context, User loggedInUser, OpenAIService openAIService)
        {
            _view = view;
            _openAIService = openAIService;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.AddPropertyClick += OnAddPropertyClick;
            _view.EditPropertyClick += OnEditPropertyClick;
            _view.DeletePropertyClick += OnDeletePropertyClick;
            _view.FilterProperties += OnFilterProperties;
            _view.BackToMenuClick += OnBackToMenuClick; 
            LoadProperties();
        }

        private void LoadProperties()
        {
            _allProperties = _context.Properties
               .Include(p => p.Address)
               .Where(p => p.UserId == _loggedInUser.UserId)
               .ToList();

            _view.SetProperties(_allProperties);
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
        private void OnFilterProperties(object sender, string filterText)
        {
            if (string.IsNullOrWhiteSpace(filterText))
            {
                _view.SetProperties(_allProperties);
            }
            else
            {
                var filteredProperties = _allProperties
                    .Where(p => !string.IsNullOrEmpty(p.Name) && p.Name.Contains(filterText, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                _view.SetProperties(filteredProperties);
            }
        }

        private void OnBackToMenuClick(object sender, EventArgs e)
        {
            var landlordMenu = new LandlordMenu(_loggedInUser);
            var landlordMenuPresenter = new LandlordMenuPresenter(landlordMenu, _context, _loggedInUser, _openAIService);
            _view.Hide();
            landlordMenu.FormClosed += (s, args) => _view.Show();
            landlordMenu.Show();
        }


    }
}

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
            var landlord = _context.Users.OfType<Landlord>()
                .Include(l => l.Properties)
                .FirstOrDefault(l => l.UserId == _loggedInUser.UserId);
            if (landlord != null)
            {
                _view.SetProperties(landlord.Properties.ToList());
            }
        }
        private void OnAddPropertyClick(object sender, EventArgs e) 
        {
            var propertyForm = new PropertyForm();
            propertyForm.FormClosed += (s, args) => LoadProperties();
            _view.ShowMessage("Pomyślnie dodano");
            propertyForm.ShowDialog();
        }
        private void OnEditPropertyClick(object sender, EventArgs e)
        {
            var selectedProperty = _view.GetSelectedProperty();
            if (selectedProperty != null)
            {
                var propertyForm = new PropertyForm(selectedProperty);
                propertyForm.FormClosed += (s, args) => LoadProperties();
                _view.ShowMessage("Pomyślnie edytowano");
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
                _view.ShowMessage("Pomyślnie usunięto");
                LoadProperties();
            }
            else
            {
                _view.ShowMessage("Wybierz nieruchomość, którą chcesz usunąć");
            }
        }


    }
}

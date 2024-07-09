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

        public PropertyFormPresenter(IPropertyFormView view, YourProplyDbContext context)
        {
            _view = view;
            _context = context;
            _view.SaveClick += OnSaveClick;
        }
        private void OnSaveClick(object sender, EventArgs e)
        {
            var property = _view.Property;
            if (property.PropertyId == 0)
            {
                _context.Properties.Add(property);
            }
            else
            {
                _context.Properties.Update(property);
            }
            _context.SaveChanges();
            _view.ShowMessage("Nieruchomość zapisana pomyślnie.");
            _view.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Entities
{
    public class Landlord : User
    {
        public Landlord(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address)
            : base(userId, userName, firstName, lastName, email, password, idNumber, address)
        {
            UserType = UserType.Landlord;
            Properties = new List<Property>();
        }

        public List<Property> Properties { get; set; }

        public override void ChangePassword(string actualPassword, string newPassword)
        {
            // Implementacja zmiany hasła
        }

        public void AddProperty(Property property)
        {
            Properties.Add(property);
            // Dodawanie do bazy danych
        }

        public void EditProperty(Property property)
        {
            // Edycja w bazie danych
        }

        public void DeleteProperty(int propertyId)
        {
            Properties.RemoveAll(p => p.PropertyId == propertyId);
            // Usunięcie z bazy danych
        }
    }

}

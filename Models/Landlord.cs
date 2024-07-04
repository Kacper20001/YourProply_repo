using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Entities
{
    public class Landlord : User
    {
        public Landlord() { }

        public Landlord(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address, DateTime dateOfBirth)
            : base(userId, userName, firstName, lastName, email, password, idNumber, address, dateOfBirth)
        {
            UserType = UserType.Landlord;
            Properties = new List<Property>();
        }

        public ICollection<Property> Properties { get; set; }
    }
}

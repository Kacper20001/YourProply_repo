using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;

namespace YourProply.Entities
{
    public class Tenant : User
    {
        public Tenant() { }

        public Tenant(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address, Property property, DateTime dateOfBirth)
            : base(userId, userName, firstName, lastName, email, password, idNumber, address, dateOfBirth)
        {
            Property = property;
            UserType = UserType.Tenant;
        }

        public Property Property { get; set; }
    }
}

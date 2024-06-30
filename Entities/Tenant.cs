using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;


namespace YourProply.Entities
{
    public class Tenant: User
    {
        public Tenant(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address, Property property) : base(userId, userName, firstName, lastName, email, password, idNumber, address)
        {
            Property = property;
            UserType = UserType.Tenant;
        }

        public Property Property { get; set; }

        public override void ChangePassword(string actualAPassword, string newPassword)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Repo
{
    public class Tenant: User
    {
        public Tenant(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address, Property property) : base(userId, userName, firstName, lastName, email, password, idNumber, address)
        {
            Property = property;
        }

        public Property Property { get; set; }

        public override void ChangePassword(string actualAPassword, string newPassword)
        {

        }

    }
}

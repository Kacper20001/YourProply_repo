using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Repo
{
    public abstract class User
    {
        protected User(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address)
        {
            UserId = userId;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IdNumber = idNumber;
            Address = address;
        }

        public int UserId {  get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdNumber {  get; set; } 
        public Address Address { get; set; }

        public abstract void ChangePassword(string actualPassword, string newPassword);
    }
}

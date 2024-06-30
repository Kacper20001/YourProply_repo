using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Entities
{
    public enum UserType
    {
        Landlord,
        Tenant
    }

    public abstract class User
    {
        public User(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address)
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

        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int IdNumber { get; set; }

        [Required]
        public Address Address { get; set; }
        [Required]
        public UserType UserType { get; set; }

        public abstract void ChangePassword(string actualPassword, string newPassword);
    }
}

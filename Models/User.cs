using System.ComponentModel.DataAnnotations;

namespace YourProply.Entities
{
    public enum UserType
    {
        Landlord,
        Tenant
    }

    public abstract class User
    {
        public User() { }

        public User(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address, DateTime dateOfBirth)
        {
            UserId = userId;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IdNumber = idNumber;
            Address = address;
            DateOfBirth = dateOfBirth;
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
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int IdNumber { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public UserType UserType { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Views
{
    public interface IRegisterView
    {
        string UserName { get; }
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; }
        string IdNumber { get; }
        string Email { get; }
        string Password { get; }
        string ConfirmPassword { get; }
        string Street { get; }
        string Number { get; }
        string City { get; }
        string PostalCode { get; }
        string Province { get; }
        string State { get; }

        event EventHandler Register;
        event EventHandler AlreadyHaveAccountClick;
        void ShowMessage(string message);
        void ClearForm();
        void Show(); 
        void Hide(); 
        void Close(); 
    }
}

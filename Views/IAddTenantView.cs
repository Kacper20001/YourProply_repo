using System;

namespace YourProply.Views
{
    public interface IAddTenantView
    {
        event EventHandler AddTenantClick;
        int UserId { get; }  // Dodaj właściwość UserId
        string UserName { get; }
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; }
        string IdNumber { get; }
        string Email { get; }
        string Password { get; }
        int SelectedPropertyId { get; }

        string Street { get; }
        string HouseNumber { get; }
        string City { get; }
        string PostalCode { get; }
        string Province { get; }
        string State { get; }

        void ShowMessage(string message);
        void Show();
        void Hide();
        void Close();
    }
}

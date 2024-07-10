using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Views
{
    public interface IAddTenantView
    {
        event EventHandler AddTenantClick;
        string UserName { get; }
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; }
        string IdNumber { get; }
        string Email { get; }
        string Password { get; }
        int SelectedPropertyId { get; }
        void ShowMessage(string message);
        void Show();
        void Hide();
        void Close();
    }
}

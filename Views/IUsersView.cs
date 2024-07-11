using System;
using System.Collections.Generic;
using YourProply.Entities;

namespace YourProply.Views
{
    public interface IUsersView
    {
        event EventHandler AddUserClick;
        event EventHandler EditUserClick;
        event EventHandler DeleteUserClick;
        event EventHandler<string> FilterUsers;
        event EventHandler BackToMenuClick;

        void SetUsers(List<Tenant> users);
        Tenant GetSelectedUser();
        void ShowMessage(string message);
        void Show();
        void Hide();
    }
}

using System;
using System.Collections.Generic;
using YourProply.Entities;

namespace YourProply.Views
{
    public interface ISendEmailView
    {
        event EventHandler SendEmailClick;
        event EventHandler BackToMenuClick;
        Tenant SelectedTenant { get; }
        string Subject { get; }
        string Body { get; }
        void SetTenants(List<Tenant> tenants);
        void ShowMessage(string message);
        void Show();
        void Hide();
        void Close();
        void ClearForm();
    }
}

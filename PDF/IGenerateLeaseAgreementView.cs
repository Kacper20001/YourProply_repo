using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.PDF
{
    public interface IGenerateLeaseAgreementView
    {
        event EventHandler BackToMenuClick;
        event EventHandler GeneratePDF;
        string LandlordFirstName { get; }
        string LandlordLastName { get; }
        string LandlordDOB { get; }
        string LandlordID { get; }

        string TenantFirstName { get; }
        string TenantLastName { get; }
        string TenantDOB { get; }
        string TenantID { get; }

        string PropertyName { get; }
        string PropertyAddress { get; }
        string PropertyType { get; }

        string RentalAmount { get; }
        string RentalStartDate { get; }
        string RentalEndDate { get; }

        void ShowMessage(string message);
        void Show();
        void Hide();
    }
}

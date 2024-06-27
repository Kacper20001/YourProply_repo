using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Repo
{
    public class Agreement
    {
        public Agreement(int agreementId, int tenantId, int propertyId, DateTime startDate, DateTime endDate, decimal monthlyRent)
        {
            AgreementId = agreementId;
            TenantId = tenantId;
            PropertyId = propertyId;
            StartDate = startDate;
            EndDate = endDate;
            MonthlyRent = monthlyRent;
        }

        public int AgreementId { get; set; }
        public int TenantId { get; set; }
        public int PropertyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MonthlyRent { get; set; }
        public static void GenerateAgreement()
        {
            // Generowanie umowy najmu
        }
    }
}

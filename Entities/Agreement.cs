using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Entities
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
        [Key]
        public int AgreementId { get; set; }

        [Required]
        public int TenantId { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [Range(0, 100000)]
        public decimal MonthlyRent { get; set; }
        public static void GenerateAgreement()
        {
            // Generowanie umowy najmu
        }
    }
}

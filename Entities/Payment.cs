using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Repo
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int LeaseAgreementId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsLate { get; set; }
        public static void CalculateLateFee()
        {
            // Obliczanie kary za opóźnienie
        }
    }
}

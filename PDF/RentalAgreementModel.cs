using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.PDF
{
    public class RentalAgreementModel
    {
        public string LandlordFirstName { get; set; }
        public string LandlordLastName { get; set; }
        public string LandlordDOB { get; set; }
        public string LandlordID { get; set; }

        public string TenantFirstName { get; set; }
        public string TenantLastName { get; set; }
        public string TenantDOB { get; set; }
        public string TenantID { get; set; }

        public string PropertyName { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyType { get; set; }

        public string RentalAmount { get; set; }
        public string RentalStartDate { get; set; }
        public string RentalEndDate { get; set; }
    }
}

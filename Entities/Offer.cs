using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Repo
{
    public class Offer
    {
        public Offer(int offerId, int propertyId, int landlordId, decimal price, DateTime availableFrom, DateTime availableTo)
        {
            OfferId = offerId;
            PropertyId = propertyId;
            LandlordId = landlordId;
            Price = price;
            AvailableFrom = availableFrom;
            AvailableTo = availableTo;
        }

        public int OfferId { get; set; }
        public int PropertyId { get; set; }
        public int LandlordId { get; set; }
        public decimal Price { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;


namespace YourProply.Entities
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

        [Key]
        public int OfferId { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public int LandlordId { get; set; }

        [Required]
        [Range(0, 100000)]
        public decimal Price { get; set; }

        [Required]
        public DateTime AvailableFrom { get; set; }

        [Required]
        public DateTime AvailableTo { get; set; }
    }
}

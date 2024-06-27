using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Repo
{
    public class Property
    {
        public Property(int propertyId, string name, string description, Address address, decimal rentPrice, bool isAvailable)
        {
            PropertyId = propertyId;
            Name = name;
            Description = description;
            Address = address;
            RentPrice = rentPrice;
            IsAvailable = isAvailable;
        }

        public int PropertyId { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public decimal RentPrice { get; set; }
        public bool IsAvailable { get; set; }
    }
}

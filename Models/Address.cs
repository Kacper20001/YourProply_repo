using System.ComponentModel.DataAnnotations;

namespace YourProply.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string Street { get; set; }
        public string Number { get; set; }
       public string PostalCode {  get; set; }
        
        public string City { get; set; }
        public string Province { get; set; }

        public string State { get; set; }

    }
}

using System;

namespace Entities.Models
{
    public class PersonAddress : BaseModel<PersonAddress>
    {
        public virtual int PersonAddressID { get; set; }
        public Entities.Enumerations.AddressType? AddressType { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public virtual Person Person { get; set; }
    }
}

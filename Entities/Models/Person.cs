using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public class Person : BaseModel<Person>
    {
        public Person()
        {
            Address = new List<PersonAddress>();
        }

        public int PersonID { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public Entities.Enumerations.Gender? Gender { get; set; }
        public Entities.Enumerations.CitizenType? Citizenship { get; set; }
        
        public virtual ICollection<PersonAddress> Address { get; set; }
    }
}

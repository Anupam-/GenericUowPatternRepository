using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models;

namespace Data.Mappings
{
    public class PersonAddressMap : EntityTypeConfiguration<PersonAddress>
    {
        public PersonAddressMap()
        {
            // Primary Key
            HasKey(p => p.PersonAddressID);

            // Properties
            Property(p => p.PersonAddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.AddressType)
                .IsRequired();

            // Relationship
            HasOptional(p => p.Person)
                .WithMany(p => p.Address)
                .WillCascadeOnDelete(false);

            // Not Mapped properties
            Ignore(p => p.State);
        }
    }
}


using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models;

namespace Data.Mappings
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            HasKey(p => p.PersonID);

            // Properties
            Property(p => p.PersonID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.SSN)
                .IsRequired()
                .HasMaxLength(9);

            // Table & Column Mappings
            ToTable("Person");

            // Not Mapped properties
            Ignore(p => p.State);
        }
    }
}

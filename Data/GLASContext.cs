using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Entities.Models;
using Data.Mappings;

namespace Data
{
    /// <summary>
    /// The DbContecxt class, this is used to Create
    /// Database by reading Connection string from Web.Config file
    /// and create tables in it  by executing the OnModelCreating
    /// method where mapping and constraints are defined.
    /// </summary>
    public class GLASContext : DbContext, IDbContext
    {
        static GLASContext()
        {
            Database.SetInitializer<GLASContext>(null);
        }

        public GLASContext()
            : base("name=GLASConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public override int SaveChanges()
        {
            this.ApplyStateChanges();
            return base.SaveChanges();
        }

        /// <summary>
        /// The below Method is used to define the Maping
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonAddressMap());

            //base.OnModelCreating(modelBuilder);
        }
    }
}

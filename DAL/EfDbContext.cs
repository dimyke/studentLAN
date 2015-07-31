using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;

using Domain;


namespace DAL
{
    // [DbConfigurationType(typeof(EfDbConfiguration))]
    public class EfDbContext : IdentityDbContext<LanUser>
    {
        public EfDbContext(): base("StudentLANDBContext")
        {
            Database.SetInitializer(new EfDbInitializer());
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Game> Games { get; set; }

        public static EfDbContext Create()
        {
            return new EfDbContext();
        }
    }
}

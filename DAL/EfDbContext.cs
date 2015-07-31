using Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace DAL
{
    public class EfDbContext : IdentityDbContext<Gebruiker>
    {
        public EfDbContext(): base("StudentLANDBContext")
        {
            Database.SetInitializer(new EfDbInitializer());
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

    }
}

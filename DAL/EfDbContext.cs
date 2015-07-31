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

        public DbSet<Bracket> Brackets { get; set; }
        public DbSet<BracketGame> BracketGames { get; set; }
        public DbSet<FoodDrinks> FoodDrinkses { get; set; }
        public DbSet<Game> Games { get; set; }
        public override IDbSet<LanUser> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine>  OrderLines { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PriceSupport> PriceSupports { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Wallet> Wallets { get; set; }



        public static EfDbContext Create()
        {
            return new EfDbContext();
        }
    }
}

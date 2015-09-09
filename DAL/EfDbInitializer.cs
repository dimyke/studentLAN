using System.Data.Entity;

namespace DAL
{
    class EfDbInitializer : CreateDatabaseIfNotExists<EfDbContext>
    {
        protected override void Seed(EfDbContext context)
        { }
    }
}

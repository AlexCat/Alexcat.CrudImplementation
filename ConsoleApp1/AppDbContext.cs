using System.Data.Entity;
using Calabonga.EntityFramework;

namespace ConsoleApp1
{
    public class AppDbContext : DbContext, IEntityFrameworkContext
    {
        public AppDbContext(): base("DefaultConnection")
        {
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            LastSaveChangesResult = new SaveChangesResult();
        }
        public SaveChangesResult LastSaveChangesResult { get; }

        public DbSet<Person> People { get; set; }
    }
}
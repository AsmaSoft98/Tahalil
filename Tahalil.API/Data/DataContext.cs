using Microsoft.EntityFrameworkCore;
using Tahalil.API.Data.SeedData;

namespace Tahalil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Anal> Anal { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserSeedData());
            modelBuilder.ApplyConfiguration(new AnalSeedData());
        }
    }
}

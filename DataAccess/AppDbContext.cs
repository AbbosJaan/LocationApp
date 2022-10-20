using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Country> Countries { get; set; } 
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>()
                .HasMany(p => p.Regions)
                .WithOne(p => p.Country)
                .HasForeignKey(p => p.CountryId);
            base.OnModelCreating(builder);
        }
        
    }
}
using Microsoft.EntityFrameworkCore;
using RentEasy.Models;

namespace RentEasy.Data
{
    public class RentEasyDbContext : DbContext
    {
        public RentEasyDbContext(DbContextOptions<RentEasyDbContext> options) : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>().Property(p => p.RentAmount).HasPrecision(18, 2);
        }
    }
}




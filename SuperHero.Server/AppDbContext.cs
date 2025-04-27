using Microsoft.EntityFrameworkCore;
using SuperHero.Server.Models;

namespace SuperHero.Server
{
    public class AppDbContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        }
    }
}
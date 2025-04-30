using Microsoft.EntityFrameworkCore;
using SuperHero.Server.Models;

namespace SuperHero.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SuperPower>().HasData(
                new SuperPower { Id = 1, SuperPoder = "Voar", Descricao = "Voa para perto ou longe do adversário, melhorando ataques e esquivas." },
                new SuperPower { Id = 2, SuperPoder = "Super Força", Descricao = "Aumenta o dano do ataque realizado ao adversário." },
                new SuperPower { Id = 3, SuperPoder = "Super velocidade", Descricao = "Dobra a velocidade de movimento." });
        }

    }
}
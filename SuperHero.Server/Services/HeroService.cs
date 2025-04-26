using SuperHero.Server.Models;

namespace SuperHero.Server.Services
{
    public class HeroService
    {
        public Hero GetById(int id)
        {
            return new Hero
            {
                Nome = "Batata",
                NomeHeroi = "BatataGirl",
                DataNascimento = new DateTime(1992, 5, 24),
                Altura = 1.68,
                Peso = 63
            };
        }
    }
}

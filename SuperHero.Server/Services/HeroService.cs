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

        public Hero CreateHero(Hero hero)
        {
            return new Hero
            {
                Nome = hero.Nome,
                NomeHeroi = hero.NomeHeroi,
                DataNascimento = hero.DataNascimento,
                Altura = hero.Altura,
                Peso = hero.Peso
            };
        }

        public IEnumerable<Hero> GetAll()
        {
            return new List<Hero>
            {
                new Hero {
                    Nome = "Batata",
                    NomeHeroi = "BatataGirl",
                    DataNascimento = new DateTime(1992, 5, 24),
                    Altura = 1.68,
                    Peso = 63
                },
                new Hero {
                    Nome = "Beterraba",
                    NomeHeroi = "BatataBoy",
                    DataNascimento = new DateTime(2001, 4, 18),
                    Altura = 1.78,
                    Peso = 85
                }
            };
        }

        public bool HeroExists(int id)
        {
            return true;
        }

        public void UpdateHero(Hero hero)
        {
            
        }

        public void DeleteHero(int id)
        {
            
        }
    }
}

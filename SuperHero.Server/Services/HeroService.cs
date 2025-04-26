using SuperHero.Server.Models;
using SuperHero.Server.Repositories;

namespace SuperHero.Server.Services
{
    public class HeroService(HeroRepository heroRepository)
    {
        public async Task<Hero> GetById(int id)
        {
            return await heroRepository.GetByIdAsync(id);
        }

        public async Task<Hero> CreateHero(Hero hero)
        {
            return await heroRepository.CreateHeroAsync(hero);
        }

        public async Task<IEnumerable<Hero>> GetAll()
        {
            return await heroRepository.GetAllAsync();
        }

        public async Task<bool> HeroExists(int id)
        {
            return await heroRepository.HeroExistsAsync(id);
        }

        public async Task UpdateHero(Hero hero)
        {
            await heroRepository.UpdateHeroAsync(hero);
        }

        public async Task DeleteHero(int id)
        {
            await heroRepository.DeleteHeroAsync(id);
        }
    }
}

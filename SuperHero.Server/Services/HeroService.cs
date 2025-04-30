using AutoMapper;
using SuperHero.Server.DTO;
using SuperHero.Server.Models;
using SuperHero.Server.Repositories;

namespace SuperHero.Server.Services
{
    public class HeroService(HeroRepository heroRepository, IMapper mapper)
    {
        public async Task<HeroDTO> GetById(int id)
        {
            var hero = await heroRepository.GetByIdAsync(id);
            return ToHeroDTO(hero);
        }

        public async Task<HeroDTO> CreateHero(HeroDTO heroDTO)
        {
            var hero = await heroRepository.CreateHeroAsync(ToHero(heroDTO));
            return ToHeroDTO(hero);
        }

        public async Task<IEnumerable<HeroDTO>> GetAll()
        {
            var heroes = await heroRepository.GetAllAsync();
            return ToHeroDTO(heroes);
        }

        public async Task<bool> HeroExists(int id)
        {
            return await heroRepository.HeroExistsAsync(id);
        }

        public async Task UpdateHero(HeroDTO hero)
        {
            await heroRepository.UpdateHeroAsync(ToHero(hero));
        }

        public async Task DeleteHero(int id)
        {
            await heroRepository.DeleteHeroAsync(id);
        }

        private Hero ToHero(HeroDTO heroDTO)
        {
            return mapper.Map<Hero>(heroDTO);
        }

        private HeroDTO ToHeroDTO(Hero hero)
        {
            return mapper.Map<HeroDTO>(hero);
        }

        private IEnumerable<HeroDTO> ToHeroDTO(IEnumerable<Hero> heroes)
        {
            var heroesDTO = mapper.Map<List<HeroDTO>>(heroes);
            return heroesDTO;
        }
    }
}

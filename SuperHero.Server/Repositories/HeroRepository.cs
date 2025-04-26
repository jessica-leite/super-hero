using Microsoft.EntityFrameworkCore;
using SuperHero.Server.Models;

namespace SuperHero.Server.Repositories
{
    public class HeroRepository
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<Hero> _dbSet;

        public HeroRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Hero>();
        }

        public async Task<Hero> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<Hero>> GetAllAsync() 
        { 
            return await _dbSet.ToListAsync();
        }

        public async Task<Hero> CreateHeroAsync(Hero hero)
        {
            await _dbSet.AddAsync(hero);
            await _dbContext.SaveChangesAsync();
            return hero;
        }
        public async Task<bool> HeroExistsAsync(int id)
        {
            return await _dbSet.AnyAsync(h => h.Id == id);
        }
        public async Task UpdateHeroAsync(Hero hero)
        {
            _dbSet.Update(hero);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteHeroAsync(int id)
        {
            var hero = await GetByIdAsync(id);
            if (hero != null)
            {
                _dbSet.Remove(hero);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}


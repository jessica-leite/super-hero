using Microsoft.AspNetCore.Mvc;
using SuperHero.Server.DTO;
using SuperHero.Server.Services;

namespace SuperHero.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeroController(HeroService heroService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var hero = await heroService.GetById(id);
            if (hero == null)
            {
                return NotFound("Herói não encontrado");
            }

            return Ok(hero);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var heroes = await heroService.GetAll();
            if(heroes == null || !heroes.Any())
            {
                return NotFound("Nenhum herói cadastrado");
            }

            return Ok(heroes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHero(HeroDTO hero)
        {
            var newHero = await heroService.CreateHero(hero);
            if (newHero == null)
            {
                return BadRequest("Não foi possível criar o herói, verifique as informações e tente novamente");
            }

            return CreatedAtAction(nameof(CreateHero), new { id = newHero.Id }, newHero);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHero(HeroDTO hero)
        {
            var heroExists = await heroService.HeroExists(hero.Id);
            if (!heroExists)
            {
                return NotFound("Não foi possível encontrar o herói, verifique as informações e tente novamente");
            }

            await heroService.UpdateHero(hero);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {
            var heroExists = await heroService.HeroExists(id);
            if (!heroExists)
                return NotFound("Não foi possível encontrar o herói");

            await heroService.DeleteHero(id);
            return NoContent();
        }
    }
}

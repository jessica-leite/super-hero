using Microsoft.AspNetCore.Mvc;
using SuperHero.Server.Models;
using SuperHero.Server.Services;

namespace SuperHero.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeroController : ControllerBase
    {
        private HeroService heroService;

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var hero = heroService.GetById(id);
            if (hero == null)
            {
                return NotFound();
            }

            return Ok(hero);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var heroes = heroService.GetAll();
            if (heroes == null || !heroes.Any())
            {
                return NotFound();
            }

            return Ok(heroes);
        }

        [HttpPost]
        public IActionResult CreateHero(Hero hero)
        {
            var newHero = heroService.CreateHero(hero);
            if (newHero == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(CreateHero), new { id = newHero.Id }, newHero);
        }

    }
}

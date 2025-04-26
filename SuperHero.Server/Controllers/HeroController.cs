using Microsoft.AspNetCore.Mvc;
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
    }
}

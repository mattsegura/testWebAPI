using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        // return list of super heros 
        private static List<SuperHero> heroes = new List<SuperHero>
            {
                new SuperHero {
                    Id = 1,
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gotham"
                }
            };



        // request data
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get() // show values within swagger
        {
            return Ok(heroes); // return to make sure everything is fine 
        }

        // send data 
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero) // show values within swagger
        {
            heroes.Add(hero);
            return Ok(heroes); // return to make sure everything is fine 
        }
    }
}

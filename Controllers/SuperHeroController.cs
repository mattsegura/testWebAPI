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
                },
                new SuperHero {
                    Id = 2,
                    Name = "Ironman",
                    FirstName = "Tony",
                    LastName = "Start",
                    Place = "Long Island"
                },
            };



        // publishing data
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get() // show values within swagger
        {
            return Ok(heroes); // return to make sure everything is fine 
        }

        // retrieving a single hero 
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> Get(int id) // show values within swagger
        {
            var hero = heroes.Find(h => h.Id == id); // searching for the hero Id within method
            if (hero == null) // checking hero 
                return BadRequest("Hero not found");
            return Ok(hero); // return to make sure everything is fine 
        }

        // adding something new  
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero) // show values within swagger
        {
            heroes.Add(hero);
            return Ok(heroes); // return to make sure everything is fine 
        }
    }
}

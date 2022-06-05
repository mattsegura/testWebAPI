using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        // get method 
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get() // show values within swagger
        {
            // return list of super heros 
            var heroes = new List<SuperHero>
            { 
                new SuperHero {
                    Id = 1,
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gotham"
                }
            };

            return Ok(heroes); // return to make sure everything is fine 
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
       
        private readonly DataContext context;

        public SuperHeroController(DataContext context)
        {
            this.context = context;
        }


        // publishing data
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get() // show values within swagger
        {
            return Ok(await context.SuperHeroes.ToListAsync()); // getting heroes from database
        }

        // retrieving a single hero 
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> Get(int id) // show values within swagger
        {
            var hero = await context.SuperHeroes.FindAsync(id); // searching for the hero Id within method
            if (hero == null) // checking hero 
                return BadRequest("Hero not found");
            return Ok(hero); // return to make sure everything is fine 
        }

        // adding something new  
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero) // show values within swagger
        {
            context.SuperHeroes.Add(hero); // changed the table
            await context.SaveChangesAsync(); // saving the change 

            return Ok(await context.SuperHeroes.ToListAsync()); // return to make sure everything is fine 
        }

        [HttpPut]

        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request) // show values within swagger
        {
            var hero = await context.SuperHeroes.FindAsync(request.Id); // searching for the hero Id within method
            if (hero == null) // checking hero 
                return BadRequest("Hero not found");

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            await context.SaveChangesAsync();

            return Ok(await context.SuperHeroes.ToListAsync()); // return to make sure everything is fine 
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<SuperHero>>> Delete(int id) // show values within swagger
        {
            var hero = await context.SuperHeroes.FindAsync(id); // searching for the hero Id within method
            if (hero == null) // checking hero 
                return BadRequest("Hero not found");
            return Ok(hero); // return to make sure everything is fine 

            context.SuperHeroes.Remove(hero);
            await context.SaveChangesAsync();

            return Ok(await context.SuperHeroes.ToListAsync());
        }
    }
}

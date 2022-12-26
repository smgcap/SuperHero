using Microsoft.AspNetCore.Mvc;

namespace SuperHeroApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuperHeroController : Controller
    {
      
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeros()
        {
            return new List<SuperHero>
            {
                new SuperHero
                {
                    Name = "Spider Man",
                    First = "Peter",
                    Last = "Parker",
                    Place = "New York City"

                }
            }; 
        }

    }
}

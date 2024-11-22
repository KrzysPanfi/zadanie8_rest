using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        public List<Animal> database = new List<Animal>();
        public AnimalsController()
        {
            Animal a1 = new Animal { Id = 1, Name = "Rex", category = "pies", color = "brown", mass = 12 };
        }
        [HttpGet]
        public IActionResult GetAnimlas()
        {
            return Ok(database);
        }
        [HttpGet("{id}")]
        public IActionResult GetAnimal(int id)
        {
            return Ok("bbb");
        }
    }
}

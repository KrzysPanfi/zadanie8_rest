using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace Lekcja8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<Animal> database = new List<Animal>();
        public AnimalsController()
        {
            Animal a1 = new Animal { Id = 1, Name = "Rex", category = "Pies", color = "Brown", mass = 12 };
            database.Add(a1);
        }

        //GET /animals
        [HttpGet]
        public IActionResult GetAnimals()
        {
            return Ok(database);
        }

        //GET animals/1
        [HttpGet("{id}")]
        public IActionResult GetAnimal(int id)
        {
            return Ok("bbbb");
        }
    }
}

using _11.week_CelebretiesApi_02.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11.week_CelebretiesApi_02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CelebretiesController : ControllerBase
    {
        private static readonly List<Celebrity> celebrities = new List<Celebrity>()
        {
            new Celebrity {Id = 1, Name = "Tarkan", Profession = "Pop Müziği Sanatçısı"},
            new Celebrity {Id = 2, Name = "Sıla", Profession = "Pop Müziği Sanatçısı"},
            new Celebrity {Id = 3, Name = "Tarkan", Profession = "Oyuncu"},
            new Celebrity {Id = 4, Name = "Tarkan", Profession = "Oyuncu" }
        };

        //GET: api/celebreties/5
        [HttpGet("{id}")]
        public ActionResult<Celebrity> Get(int id)
        {
            var celebrity = celebrities.FirstOrDefault(c => c.Id == id);
            if(celebrities == null)
            {
                return NotFound();
            }

            return Ok(celebrity);
        }
        //POST : api/celebreties
        [HttpPost]
        public IActionResult Post([FromBody] Celebrity celebrity)
        {
            celebrity.Id = celebrities.Max(c => c.Id) + 1;
            celebrities.Add(celebrity);
            return CreatedAtAction(nameof(Get), new { id = celebrity.Id, celebrity });
        }

        //PUT: api/celebreties
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Celebrity updatedCelebrity)
        {
            var celebretiy = celebrities.FirstOrDefault(c => c.Id == id);
            if(celebrities == null)
            {
                return NotFound();
            }
            celebretiy.Name = updatedCelebrity.Name;
            celebretiy.Profession = updatedCelebrity.Profession;

            return NoContent();

        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var celebrity = celebrities.FirstOrDefault(c => c.Id == id);
            if(celebrity == null)
            {
                return NotFound();
            }

            celebrities.Remove(celebrity);

            return NoContent();
        }

    }
}

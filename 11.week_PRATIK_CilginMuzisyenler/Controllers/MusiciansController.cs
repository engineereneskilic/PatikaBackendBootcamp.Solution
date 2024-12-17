using _11.week_PRATIK_CilginMuzisyenler.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _11.week_PRATIK_CilginMuzisyenler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        // Static data simulating a database.
        // List of musicians with initial dummy data.
        private static List<Musician> musicians = new List<Musician>
        {
            new Musician { Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar" , FunTrait="Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new Musician { Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", FunTrait="Şarkıları yanlış anlaşılır ama çok popüler"},
            new Musician { Id = 2, Name = "Cemil Akor", Profession = "Çılgın Akorist", FunTrait="Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli"},
            new Musician { Id = 2, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", FunTrait = "Nota üretirken sürekli sürprizler hazırlar"},
            new Musician { Id = 2, Name = "Hasan Ritim", Profession = "Ritim Canavarı", FunTrait = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir"},
            new Musician { Id = 2, Name = "Elif Armoni", Profession = "Armoni Ustası", FunTrait = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır"},
            new Musician { Id = 2, Name = "Ali Perde", Profession = "Perde Uygulayıcı", FunTrait = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir"},
            new Musician { Id = 2, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", FunTrait = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır"},
            new Musician { Id = 2, Name = "Murat Ton", Profession = "Tonlama Meraklısı", FunTrait = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç"},
            new Musician { Id = 2, Name = "Selin Akor", Profession = "Akor Sihirbazı", FunTrait = "Akorlar değiştiğinde bazen sihirli bir hava yaratır"}

        };

        //GET: api/musicians
        // Retrieves all musicians from the static list.
        [HttpGet]
        public ActionResult<IEnumerable<Musician>> GetAllMusicians()
        {
            return Ok(musicians);
        }


        //GET: api/musicians/search?name=Cemil
        // Searches musicians by name using the [FromQuery] attribute.
        [HttpGet("search")]
        public ActionResult<IEnumerable<Musician>> SearchMusicians([FromQuery] string name)
        {
            var result = musicians.Where(m => m.Name.Contains(name)).ToList();
            if (!result.Any())
            {
                return NotFound($"No musicians found with name containing '{name}'.");
                
            }

            return Ok(result);
        }

        //GET: api/musicians/1
        // Retrieves a specific musician by ID.

        [HttpGet("id")]
        public ActionResult<Musician> GetMusicianById(int id)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);

            if(musician == null)
            {
                return NotFound($"Musician with ID {id} not found");
            }

            return Ok(musician);
        }

        //POST: api/musicians
        // Adds a new musician to the list.

        [HttpPost]
        public ActionResult<Musician> AddMusician([FromBody] Musician newMusician)
        {
            if(newMusician == null || string.IsNullOrWhiteSpace(newMusician.Name))
                return BadRequest("Invalid musician data.");

            newMusician.Id = musicians.Max(m => m.Id) + 1;
            musicians.Add(newMusician);

            return CreatedAtAction(nameof(GetMusicianById), new { id = newMusician.Id }, newMusician);
        }

        //PUT: api/musicians/3
        // Updates an entire musician record.

        [HttpPut("{id}")]
        public ActionResult UpdateMusician(int id, [FromBody] Musician updateMusician)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);

            if(musician == null)
            {
                return NotFound($"Musician with ID {id} not found");
            }

            if (string.IsNullOrWhiteSpace(updateMusician.Name))
            {
                return BadRequest("Name field cannot be empty");
            }

            musician.Name = updateMusician.Name;
            musician.Profession = updateMusician.Profession;
            musician.FunTrait = updateMusician.FunTrait;

            return NoContent();
        }

        //PATCH: api/musicians/2
        // Partially updates the FunTrait of a musician.

        [HttpPatch("{id}")]
        public ActionResult UpdateMusicianPartial(int id, [FromBody] string newFunTrait)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);

            if(musician == null)
            {
                return NotFound($"Musician with ID {id} not found.");
            }

            if(string.IsNullOrWhiteSpace(newFunTrait))
            {
                return BadRequest("FunTrait cannot be emtpy.");
            }

            musician.FunTrait = newFunTrait;

            return Ok(musician);
        }

        //DELETE api/musician/1
        [HttpDelete("{id}")]
        // Deletes a musician record by ID.
        public ActionResult DeleteMusician(int id)
        {
            var musucian = musicians.FirstOrDefault(m => m.Id == id);

            if (musucian == null)
                return NotFound($"Musician with ID {id} not found");

            musicians.Remove(musucian);
            return NoContent();
        }
    }
}

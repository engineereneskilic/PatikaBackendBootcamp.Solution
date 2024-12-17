using _11.week_GalacticTour_03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace _11.week_GalacticTour_03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalacticToursController : ControllerBase
    {
        private static List<GalacticTour> _galacticTours = new List<GalacticTour>()
        {
            new GalacticTour { Id = 1,PlanetName = "Mars", Duration = "2 ay", Price = 500000},
            new GalacticTour { Id = 1,PlanetName = "Venüs", Duration = "1 ay", Price = 100000},
            new GalacticTour { Id = 1,PlanetName = "Mars", Duration = "2 ay", Price = 300000},

        };

        [HttpGet]
        public IEnumerable<GalacticTour> GetAll()
        {
            return _galacticTours;
        }

        [HttpGet("{id:int:min(1)}")]
        public ActionResult<GalacticTour> GetTour(int id, [FromHeader(Name = "X-Planet")] string planet)
        {
            var tour = _galacticTours.FirstOrDefault(x => x.Id == id);
            if (tour is null)
            {
                return NotFound($"Tur Id {id} bulunamadı");
            }

            return Ok(tour);
        }

        [HttpGet("planed/{planetName:alpha}")]
        public ActionResult<IEnumerable<GalacticTour>> GetToursByPlanet(string planetName)
        {
            var planetTours = _galacticTours.Where(t => t.PlanetName.Equals(planetName, StringComparison.OrdinalIgnoreCase));
            if (planetTours.Any())
            {
                return NotFound($"{planetName} için tyr bulunamadı");
            }

            return Ok(planetTours);
        }

        [HttpGet("price-range")]
        //api/galacticours/price-range?minPrice=50&maxPrice=60
        public ActionResult<IEnumerable<GalacticTour>> GetToursByPriceRange([FromQuery] decimal minPrice, [FromQuery] decimal maxPrice)
        {
            var filteredTours = _galacticTours.Where(t => t.Price >= minPrice && t.Price <= maxPrice);

            return Ok(filteredTours);
        }

        [HttpPost]
        public ActionResult<GalacticTour> Create([FromBody] GalacticTour tour)
        {
            var id = _galacticTours.Max(t => t.Id);
            tour.Id = id;

            _galacticTours.Add(tour);

            return CreatedAtAction(nameof(GetTour), new { id = tour.Id }, tour);
        }

        [HttpPost("create-package")]
        public ActionResult<GalacticTour> CreateTourPackage([FromBody] GalacticTourPackage galacticTourPackage)
        {
            var tour = new GalacticTour
            {
                Id = _galacticTours.Max(t => t.Id) + 1,
                PlanetName = galacticTourPackage.Destination,
                Duration = $"{galacticTourPackage.DurationInDays} Gün",
                Price = galacticTourPackage.BasePrice * galacticTourPackage.DurationInDays
            };

            _galacticTours.Add(tour);

            return CreatedAtAction(nameof(GetTour), new { id = tour.Id }, tour);
        }

        [HttpPut("update/{id:int:min(1)}/{newPlanetName}")]
        public IActionResult UpdateTourPlanet(int id, string newPlanetName)
        {
            var tour = _galacticTours.FirstOrDefault(t => t.Id == id);
            if (tour == null)
            {
                return NotFound($"Tur id {id} bulunamadı");
            }

            tour.PlanetName = newPlanetName;

            return NoContent();
        }

        [HttpDelete("{id:int:min(1)}")]
        [HttpDelete("cancel/{tourName}")]
        public IActionResult CancelTour(int? id, string tourName)
        {
            GalacticTour tourtoRemove;

            if (id.HasValue)
            {
                tourtoRemove = _galacticTours.FirstOrDefault(t => t.Id == id);
            } else
            {
                tourtoRemove = _galacticTours.FirstOrDefault(t => t.PlanetName.Equals(tourName, StringComparison.OrdinalIgnoreCase));
            }

            if (tourtoRemove == null)
            {
                return NotFound("Belirtilen tur bulunamadı");
            }

            _galacticTours.Remove(tourtoRemove);

            return NoContent();
        }

        [HttpPatch("reschedule/{id:int:min(1)}/{newDate:datetime}/")]
        public IActionResult RescheduleTour(int id, DateTime newDate, [FromBody] JsonPatchDocument<GalacticTour> jsonPatchDocument)
        {
            var tour = _galacticTours.FirstOrDefault(t => t.Id == id);
            if (tour is null)
            {
                return NotFound($"Tur id {id} bulunamadı");
            }

            tour.DepartureDate = newDate;

            jsonPatchDocument.ApplyTo(tour);

            return NoContent();
        }
        //[HttpGet("{id:int:min(}")]

        //POST: /api/galactictours/complex-search?name=test&minPrice400
        //  Header : X-Planet : Mars
        //  Body: {
        //   "DepartureDate": "2023-01-01",
        //   "Duration": "2 ay"
        //}
        [HttpPost("complex-search")]
        public ActionResult<IEnumerable<GalacticTour>> ComplexSearch([FromQuery] string name, [FromQuery] decimal? minPrice, [FromHeader(Name = "X-Planet") ] string planet, [FromBody] SearchCriteria searchCriteria)
        {
            if(!string.IsNullOrEmpty(name))
            {
                if(minPrice.HasValue)
                {
                    
                }
            }

            return Ok(Enumerable.Empty<GalacticTour>());
        }

    }
}

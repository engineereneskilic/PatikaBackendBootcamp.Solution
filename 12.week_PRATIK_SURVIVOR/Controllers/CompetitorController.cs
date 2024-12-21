using _12.week_PRATIK_SURVIVOR.Data;
using _12.week_PRATIK_SURVIVOR.DTos;
using _12.week_PRATIK_SURVIVOR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _12.week_PRATIK_SURVIVOR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorController(SurvivorDbContext context)
        {
            _context = context;
        }

        // GET: api/compitiros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competitor>>> GetCompetitors()
        {
            //Dtosuz
            //return await _context.Competitors.Include(c => c.Category).ToListAsync();
            var competitors = await _context.Competitors.Include(c => c.Category).ToListAsync();

            var competitorDTOs = competitors.Select(c => new CompetitorDTO
            {
                Id = c.Id,
                FullName = $"{c.FirstName} {c.LastName}",
                CategoryName = c.Category != null ? c.Category.Name : "Unknown"
            }).ToList();

            return Ok(competitorDTOs);
        }

        // GET api/competitors/{id}
        [HttpGet("id")]
        public async Task<ActionResult<Competitor>> GetCompetitor(int id)
        {
            var competitor = await _context.Competitors.Include(c => c.Category).FirstOrDefaultAsync(c => c.Id == id);

            if(competitor == null)
            {
                return NotFound();
            }
           

            var competitorDTO = new CompetitorDTO
            {
                Id = competitor.Id,
                FullName = $"{competitor.FirstName} {competitor.LastName}",
                CategoryName = competitor.Category != null ? competitor.Category.Name : "Unknown"
            };

            return Ok(competitorDTO);
        }

        //POST: api/competitors
        [HttpPost]
        public async Task<ActionResult<Competitor>> PostCompetitor(Competitor competitor)
        {
            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompetitor", new { id = competitor.Id }, competitor);
        }

        //PUT: api/competitors/{id}
        public async Task<IActionResult> PutCompetitor(int id, Competitor competitor)
        {
            if(id != competitor.Id)
            {
                return BadRequest();
            }

            _context.Entry(competitor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!CompetitorExists(id))
                {
                    return NotFound();
                } else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetitor(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if(competitor == null)
            {
                return NotFound();
            }
            _context.Competitors.Remove(competitor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompetitorExists(int id)
        {
            return _context.Competitors.Any(e => e.Id == id);
        }

    }
}

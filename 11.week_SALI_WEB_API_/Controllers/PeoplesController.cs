using _11.week_SALI_WEB_API_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _11.week_SALI_WEB_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
        // Get: api/Kisiler
        [HttpGet]
        public List<Kisi> Get()
        {
            return Veri.Kisiler();
        }

        // Get: api/Kisiler/3
        [HttpGet("{id}")]
        public ActionResult<Kisi> Get(int id)
        {
            Kisi? kisi = Veri.Kisiler().FirstOrDefault(x => x.Id == id);

            if (kisi == null) return NotFound();

            return Ok(kisi);
        }

    }
}

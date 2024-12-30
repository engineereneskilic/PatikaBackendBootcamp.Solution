using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14.week_01_IdentityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [Authorize]
        [HttpGet("test")]
        public IActionResult Get()
        {
            return Ok(new {message = "Bu bir test mesajıdır. İçedesiniz Hoşgeldiniz :)"});
        }

    }
}

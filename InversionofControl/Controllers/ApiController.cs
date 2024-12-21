using _13.week_1_InversionofControl.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13.week_1_InversionofControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IMyService _myService;

        public ApiController(IMyService myService)
        {
            _myService = myService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _myService.DoSomething();
            return Ok();
        }


    }
}

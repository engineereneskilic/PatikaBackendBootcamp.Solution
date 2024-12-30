using _13.week_04_Middleware.Dtos;
using _13.week_04_Middleware.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13.week_04_Middleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private WeatherComService _weatherComService;

        public WeatherController()
        {
            _weatherComService = new WeatherComService();
        }

        [HttpGet("Sicaklik")]
        public SonucDto GetSicaklik(string sehir)
        {
            var dto = new SonucDto()
            {
                Sehir = sehir,
                Sicaklik = _weatherComService.GetTemperature(sehir)
            };

            return dto;
        }

    }
}

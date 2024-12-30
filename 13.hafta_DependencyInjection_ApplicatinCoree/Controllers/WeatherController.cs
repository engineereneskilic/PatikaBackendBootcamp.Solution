using _13.hafta_DependencyInjection_ApplicatinCoree.Dtos;
using _13.hafta_DependencyInjection_ApplicatinCoree.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13.hafta_DependencyInjection_ApplicatinCoree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public ActionResult <WeatherDataDto> GetTemperatureByCityName(string city)
        {
           
        }
    }
}

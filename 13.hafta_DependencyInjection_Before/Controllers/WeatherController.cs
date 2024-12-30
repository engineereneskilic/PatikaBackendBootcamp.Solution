using _13.hafta_DependencyInjection_Before.Dtos;
using _13.hafta_DependencyInjection_Before.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13.hafta_DependencyInjection_Before.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        // Bu bize hizmet türünden bağımsız kod yazma esnekliği sağkayacak (ister mgm ister weather com service kullanarak bunu yapcaz)
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

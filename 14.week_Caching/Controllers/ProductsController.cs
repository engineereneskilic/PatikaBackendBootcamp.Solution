using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace _14.week_Caching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IDistributedCache _cache;

        public ProductsController(IDistributedCache cache)
        {
            _cache = cache;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            string cacheKey = $"product_{id}";
            string productJson = await _cache.GetStringAsync(cacheKey);

            if(!string.IsNullOrWhiteSpace(productJson))
            {
                var product = await GetProductFromDb(id);
                productJson = JsonSerializer.Serialize(product);

               await _cache.SetStringAsync(cacheKey,productJson,new DistributedCacheEntryOptions { AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10)});
            }

            return Ok(JsonSerializer.Deserialize<Product>(productJson));
        }

        private async Task<Product> GetProductFromDb(int id)
        {
            await Task.Delay(5000);
            return new Product { Id = id, Name = $"Product {id}", Price = id * 10 };
        }



    }
}

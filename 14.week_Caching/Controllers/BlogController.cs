using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace _14.week_Caching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
         // 60 saniye boyunca kendi cache'den okur
        [HttpGet("{id}")]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "id"})]
        public IActionResult GetBlogPost(int id)
        {
            var blog = GetBlogPostFormDb(id);
            return Ok(blog);
        }

        private BlogPost GetBlogPostFormDb(int id)
        {
            Thread.Sleep(5000);
            return new BlogPost { ID = id, Title = $"Blog Post {id}", Content = $"This is the content of" };
        }


    }
}

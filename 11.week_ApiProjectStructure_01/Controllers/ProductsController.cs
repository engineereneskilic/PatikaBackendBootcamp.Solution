using _11.week_ApiProjectStructure_01.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace _11.week_ApiProjectStructure_01.Controllers
{

    [ApiController]
    [Route("api/[controlller]")]
    public class ProductsController : ControllerBase // viewledan arındırılmış bir Base ihtiyacım var.
    {
        // api/products/2
        private static List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Product1", Price=200 },
            new Product { Id = 2, Name = "Product2", Price=300 },
        };


        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }


        [HttpGet("{id:int:min(1)}",Name = "GetProductById")]
        public IActionResult Get(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if(product is null)
            {
                return NotFound();
            }

            return Ok(product);

        }

        [HttpGet("featured",Order = 1)]
        public IActionResult GetFeaturedProducts()
        {

        }

        [HttpGet("search")]
        // search?keyword=deneme?page?1
        public IActionResult Search([FromQuery] string keyword, [FromQuery] int? page = 1)
        {
            
        }
        [HttpGet("search/{keyword:alpha:minlength(3)}")]
        // search?keyword=deneme?page?1
        public IActionResult Search(string keyword)
        {

        }

        [HttpPatch["{id}"]]
        public IActionResult PartialUpdateProduct(int id, [FromBody] JsonPatchDocument<Product> patchDocument)
        {

        }

        [HttpGet("category/{categoryName}")] 
        public IActionResult GetProductsByCategory(string categoryName)
        {

        }

        [HttpGet("date/{date:datetime}")]
        public IActionResult GetProductsByDate(DateTime dateTime)
        {

        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            var id =_products.Max(x => x.Id) + 1;
            product.Id = id;
            _products.Add(product);


            return CreatedAtRoute("GetProductById", new { id = product.Id },product);
            //return CreatedAtAction(nameof(Get),new { id = product.Id },product); // Htpp 201
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if(product == null || id != product.Id)
            {
                return BadRequest();
            }

            var existingProduct = _products.FirstOrDefault(x => x.Id == id);

            if (existingProduct is null)
            {
                return NotFound();                
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            return Ok(existingProduct);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var existingProduct = _products.FirstOrDefault(y => y.Id == id);
            if(existingProduct is null)
            {
                return NotFound();
            }

            _products.Remove(existingProduct);

            return NoContent();
        }



    }
}

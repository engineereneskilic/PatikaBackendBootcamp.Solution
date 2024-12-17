using _11.week_GalacticTour_03.ModelBindings;
using _11.week_GalacticTour_03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _11.week_GalacticTour_03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalacticProductsController : ControllerBase
    {
        private static List<GalacticProduct> _products = new List<GalacticProduct>
        {

            new GalacticProduct{Id = 1,GalacticRating = 5,ManifacturingDate = DateTime.Now.AddYears(-1),Name = "Product 1", Planet = "Merkür",Price = 4 }
        }

        [HttpGet("{id}")]
        public ActionResult<GalacticProduct> Get(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);

            if(_products == null)
            {
                return NotFound();

            }

            return Ok(Product)
        }
       
        public ActionResult<GalacticProduct> Post([FromBody] GalacticProduct product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _products.Add(product);

            return CreatedAtAction(nameof(Get))
        }

        [HttpGet("products-at-location/{location}")]
        public ActionResult<IEnumerable<GalacticProduct>> GetProductsAtLocation([ModelBinder(BinderType = typeof(GalacticCoordinateBinder))]GalacticCordinate location)
        {
            if(ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(_products);

        }

    }
}

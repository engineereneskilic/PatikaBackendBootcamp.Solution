using _12.week_MiniECommerce.Data;
using _12.week_MiniECommerce.Models;
using _12.week_PRATIK_SURVIVOR.DTos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _12.week_MiniECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public CategoriesController(ECommerceContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CategoryDTO),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            var category = _context.Categories.FirstOrDefaultAsync(c => c.Id == id);

            if(category == null)
            {
                return NotFound();
            }

            return Ok(new CategoryDTO { Id = category.Id, Name = category.Name });
        }


        [HttpPost]
        public async Task<ActionResult<Category>> Create(Category category )
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            var newProduct = new Product
            {
                CategoryID = category.Id,
                Description = "Kategori ekleden geldi",
                Name = "Product 1",
                Price = 10,
                StockQuantity = 10
            };

            _context.Products.Add(newProduct);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById),new { id = category.Id },category);
        }
    }
}

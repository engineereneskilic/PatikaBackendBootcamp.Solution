using _12.week_MiniECommerce.Data;
using _12.week_MiniECommerce.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _12.week_MiniECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public ProductsController(ECommerceContext context)
        {
            _context = context;
        }

        [HttpPut("{productName}")]
        public async Task<IActionResult> UpdateProduct(string productName,ProductUpdateDto productUpdateDto)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Name == productName);
            if (product == null)
            {
                return NotFound($"{productName} adlı ürün bulunamadı");
            }

            try
            {
                product.Price *= ( 1 + (productUpdateDto.PriceIncreasePercentage / 100));
                product.StockQuantity += productUpdateDto.StockIncrease;

                await _context.SaveChangesAsync();

                return Ok(new
                {
                    Message = "Ürün Güncellendi",
                    productName = productName,
                    NewPrice = product.Price,
                    NewStockQuantity = product.StockQuantity
                });
            }
            catch (Exception)
            {

                return StatusCode(500, "Ürün Güncellenirken Hata Oluştu");
            }
        }
    }
}

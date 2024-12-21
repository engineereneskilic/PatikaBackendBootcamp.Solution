using _12.week_MiniECommerce.Data;
using _12.week_MiniECommerce.Dto;
using _12.week_MiniECommerce.Models;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

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

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdatePrice(int id, [FromBody] JsonPatchDocument<Product> patchDocument)
        {
            if (patchDocument is null) return BadRequest("patch döküman boş olamaz");

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound("Ürün bulunamadı");
            }

            try
            {
                patchDocument.ApplyTo(product);

                if (product.Price <= 0)
                {
                    return BadRequest("Fiyat sıfır veya sıfırdan küçük olamaz");
                }
                await _context.SaveChangesAsync();

                return Ok(product);

            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = ex.Entries.Single();

                var clientValues = entry.Entity as Product;

                var databaseEntry = entry.GetDatabaseValues();

                if(databaseEntry != null)
                {
                    return NotFound("Ürün silinmiş");
                }

                var databaseValues = databaseEntry.ToObject() as Product;
                ModelState.AddModelError(string.Empty, "bu ürün fiyatı daha önce başka bir kullanıcı tarafından değiştirilmiştir.");


                return Conflict(new
                {
                    Message = "Conflict oluştu. Ürün başka bir kullanıcı tarafından güncellendi",
                    CurrentDatabaseValues = databaseValues,
                    YourAttempedValues = clientValues
                });


            }
           
            catch(Exception ex)
            {
                return StatusCode(500, "Hata oluştu");
            }
        }



    }
}

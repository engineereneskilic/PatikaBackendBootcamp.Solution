using _12.week_MiniECommerce.Data;
using _12.week_MiniECommerce.Dto;
using _12.week_MiniECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _12.week_MiniECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public OrdersController(ECommerceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Order>> GetById(int id)
        {
            var order = _context.Orders.FirstOrDefaultAsync(o => o.Id == id);

            if (order == null) NotFound();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create(CreateOrderDto order)
        {
            //_context.Orders.Add(order);

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var newOrder = new Order
                {
                    CustomerId = order.CustomerId,
                    OrderDate = DateTime.Now,
                    TotalAmount = 0
                };


                _context.Orders.Add(newOrder);
                await _context.SaveChangesAsync();

                decimal totalAmount = 0;
                foreach (var item in order.OrderItems)
                {
                    var product = await _context.Products.FindAsync(item.productId);
                    
                    if (product is null) throw new Exception($"{item.productId} id li ürün bulunamadı");

                    if (product.StockQuantity < item.quantity) throw new Exception($"{item.productId} üründen yeterli stok yok");

                    var orderDetail = new OrderDetail()
                    {
                        OrderId = newOrder.Id,
                        ProductId = item.productId,
                        Quantity = item.quantity,
                        UnitPrice = product.Price
                    };

                    _context.OrderDetails.Add(orderDetail);
                    totalAmount += orderDetail.Quantity * orderDetail.UnitPrice;

                    product.StockQuantity -= item.quantity;
                    _context.Products.Update(product);
                }

                newOrder.TotalAmount = totalAmount;
                _context.Orders.Update(newOrder);

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();

                return CreatedAtAction(nameof(GetById), new { id = newOrder.Id }, newOrder);

            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }




        }

        [HttpDelete("deleteold")]
        public async Task<IActionResult> DeleteOldOrders([FromQuery] int yearsold = 1)
        {
            if(yearsold < 0)
            {
                return BadRequest("Yıl bilgisi pozitif sayı olmalıdır");
            }

            var cuttOfDate = DateTime.Now.AddYears(-yearsold); // 1 yıl geriye git

            int totalDeletedCount = 0;

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                int batchSize = 1000;
                bool continueDeletion = true;
                while (continueDeletion)
                {
                    var oldOrders = await _context.Orders
                                                      .Where(o => o.OrderDate < cuttOfDate)
                                                      .Include(o => o.OrderDetails)
                                                      .Take(batchSize).ToListAsync();

                    if (!oldOrders.Any())
                    {
                        continueDeletion = false;
                        continue;
                    }

                    foreach (var oldOrder in oldOrders)
                    {
                        _context.OrderDetails.RemoveRange(oldOrder.OrderDetails);
                    }

                    _context.Orders.RemoveRange(oldOrders);

                    var deletedCount =  await _context.SaveChangesAsync();

                    totalDeletedCount += deletedCount;
                }
                await transaction.CommitAsync();

                return Ok(new
                {
                    Message = $"{totalDeletedCount} adet order detayları ile birlikte silindi",
                    DeletedCount = totalDeletedCount
                });
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                return StatusCode(500,"Bir hata oluştu");

                throw;
            }

        }


    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace _12.week_MiniECommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }
        public Decimal TotalAmount { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

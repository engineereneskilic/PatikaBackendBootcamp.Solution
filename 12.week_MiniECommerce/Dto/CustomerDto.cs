using _12.week_MiniECommerce.Models;

namespace _12.week_MiniECommerce.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public DateTime SignUpDate { get; set; }

        public List<Order> Orders { get; set; }
    }
}

using _8.week_2_PRATIK_CustomerOrder.Models;
using Microsoft.AspNetCore.Mvc;

namespace _8.week_2_PRATIK_CustomerOrder.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer1 = new Customer()
            {
                CustomerID = 1,
                Email = "eneskilic@gmail.com",
                FirstName = "ENES",
                LastName = "KILIÇ"
            };
            Customer customer2 = new Customer()
            {
                CustomerID = 1,
                Email = "emreaydin@gmail.com",
                FirstName = "EMRE",
                LastName = "AYDIN"
            };
            Customer customer3 = new Customer()
            {
                CustomerID = 1,
                Email = "pelinkara@gmail.com",
                FirstName = "PELİN",
                LastName = "KARA"
            };

            Order order1 = new Order()
            {
                OrderID = 1,
                Price = 22,
                ProductName = "Filiz Burgulu Makarna"
            };
            Order order2 = new Order()
            {
                OrderID = 2,
                Price = 32,
                ProductName = "Sütaş Süt"
            };
            Order order3 = new Order()
            {
                OrderID = 3,
                Price = 35,
                ProductName = "Doritos Peynirli Cips"
            };


            CustomerOrderViewModel customerOrderViewModel = new CustomerOrderViewModel()
            {
                Customer = customer1,
                Orders = new List<Order> { order1, order2, order3 }
            };

            return View();
        }
    }
}

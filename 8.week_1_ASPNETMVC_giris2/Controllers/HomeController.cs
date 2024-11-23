using _8.week_1_ASPNETMVC_giris2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _8.week_1_ASPNETMVC_giris2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Detail()
        {
            ProductViewModel productViewModel = new ProductViewModel();

            productViewModel.Product = new Product
            {
                Id = 1,
                Name = "Test",
                Price = 100
            };

            productViewModel.Review = new List<string> { "yorum 1" };
            productViewModel.IsInStock = true;

            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(product); // iþlem olmamýþsa
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

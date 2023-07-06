using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RazorSymbolebonnes_pratiques.Models;

namespace RazorSymbolebonnes_pratiques.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private List<Item> GetItems()
        {
            List<Item> items = new List<Item>
        {
            new Item { Amount = 5000000 },
            new Item { Amount = 3000000 },
            new Item { Amount = 2000000 }
        };

            return items;
        }

        public IActionResult Index()
        {
            List<Item> items = GetItems();

            return View(items);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Proiect_HCI.Models;
using System.Diagnostics;

namespace Proiect_HCI.Controllers
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

        public IActionResult AboutUs()
        {
            return View();
        }

		public IActionResult Itinerary()
		{
			return View();
		}

		public IActionResult Search()
		{
			return View();
		}
		public IActionResult Profile()
		{
			return View();
		}

		public IActionResult _SignUp()
		{
			return PartialView();
		}
		public IActionResult _SignIn()
		{
			return PartialView();
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
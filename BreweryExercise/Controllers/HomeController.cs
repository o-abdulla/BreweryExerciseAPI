using BreweryExercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BreweryExercise.Controllers
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

        [HttpPost]
        public IActionResult Brewery(string city)
        {
            List<BreweryModel> result = BreweryDAL.GetBreweries(city);
            return View(result);
        }

        [HttpGet]
        public IActionResult Brewery()
        {
            return View();
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
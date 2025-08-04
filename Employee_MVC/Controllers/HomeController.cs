using System.Diagnostics;
using Employee_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_MVC.Controllers
{
   
    public class HomeController : Controller
    {
        //First GitHub Test

        // This comment added from GitHub

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

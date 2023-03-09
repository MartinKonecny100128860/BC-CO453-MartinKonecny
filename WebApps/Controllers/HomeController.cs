using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApps.Models;
using ConsoleAppProject.App01;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DistanceConverter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DistanceConverter()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StudentMarks()
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
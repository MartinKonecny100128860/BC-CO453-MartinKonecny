using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApps.Models;


namespace WebApps.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if (converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }


        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }


        [HttpPost]
        public IActionResult BMICalculator(BMI bmi)
        {
            if (bmi.Centimetres > 140)
            {
                bmi.CalculateMetricBMI();
            }
            else if (bmi.Feet > 4 && bmi.Stones > 6)
            {
                bmi.CalculateImperialBMI();
            }
            else
            {
                ViewBag.Error = "These values are too small for an adult!";
                return View();
            }
            double Index = bmi.Index;

            return RedirectToAction("GetHealthMessage", new { Index });
        }

        public IActionResult GetHealthMessage(double Index)
        {
            return View(Index);
        }


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
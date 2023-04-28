using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult StudentMarks()
        {

            return View();
        }
       
        public IActionResult NetworkApp()
        {

            return View();
        }
     
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            return View(converter);
        }
        [HttpGet]
        public IActionResult BmiCalculator(BMI model)
        {
            return View(model);
        }

        public IActionResult BmiResultM(BMI model)
        {
            ViewBag.BMIResult = model.BMIcalc(false);
            ViewBag.BMIDescription = model.BMIdescription(0);
            ViewBag.BMIColour = model.BMIdescription(1);
            return View();
        }

        public IActionResult BmiResultI(BMI model)
        {
            ViewBag.BMIResult = model.BMIcalc(true);
            ViewBag.BMIDescription = model.BMIdescription(0);
            ViewBag.BMIColour = model.BMIdescription(1);
            return View();
        }
        public IActionResult GetHealthMessage(BMI bmiIndex)
        {
            return View(bmiIndex);
            
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

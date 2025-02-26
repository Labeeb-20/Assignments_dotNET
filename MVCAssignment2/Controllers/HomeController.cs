using Microsoft.AspNetCore.Mvc;
using MVCAssignment2.Models;

namespace MVCAssignment2.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(RentCalculator rent)
        {  
            return RedirectToAction("Calculate",rent);
        }
        [HttpGet]
        public IActionResult Calculate(RentCalculator rent)
        {
            ViewBag.Name = rent.Name;
            ViewBag.Owner = rent.HallOwner;
            ViewBag.cost = rent.costPerDay;
            ViewBag.start = rent.StartDate;
            ViewBag.end = rent.EndDate;
            var totalCost = (((rent.EndDate).Day - (rent.StartDate).Day) + 1) * rent.costPerDay;
            ViewBag.totalCost = totalCost;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVCAssignment3.Models;

namespace MVCAssignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly HallDAO hd;
        public HomeController(HallDAO hd)
        {
            this.hd = hd;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display(int price)
        {
            var halls = hd.getHall(price);

            if(halls.Count == 0)
            {
                ViewBag.Message = "No halls present in the range";
            }
                return View(halls);
        }
    }
}

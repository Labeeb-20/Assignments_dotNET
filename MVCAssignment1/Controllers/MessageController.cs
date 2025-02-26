using Microsoft.AspNetCore.Mvc;

namespace MVCAssignment1.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayName(string Username)
        {
            ViewBag.Name = Username;
            return View();
        }
    }
}

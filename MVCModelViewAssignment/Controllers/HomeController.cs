using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCModelViewAssignment.Models;

namespace MVCModelViewAssignment.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IMovieDataAccess dbctx;
        public HomeController(IMovieDataAccess dbctx) {
            this.dbctx = dbctx;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var movies = new MovieVM
            {
                Movies = dbctx.GetMovies()
            };
            return View(movies);
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            dbctx.AddMovie(movie);
            return RedirectToAction("Index");
        }
    }
}

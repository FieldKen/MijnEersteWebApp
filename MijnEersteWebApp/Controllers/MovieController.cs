using Microsoft.AspNetCore.Mvc;
using MijnEersteWebApp.Database;
using MijnEersteWebApp.Models;

namespace MijnEersteWebApp.Controllers
{
    public class MovieController : Controller
    {
        private IMovieDatabase movieDatabase;

        public MovieController(IMovieDatabase movieDatabase)
        {
            this.movieDatabase = movieDatabase;
        }

        public IActionResult Index()
        {
            var vm = movieDatabase.GetMovies().Select(x => new MovieListViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            });

            return View(vm);
        }
    }
}

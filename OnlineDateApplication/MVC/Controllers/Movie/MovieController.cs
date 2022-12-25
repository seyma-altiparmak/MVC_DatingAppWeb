using Microsoft.AspNetCore.Mvc;
using OnlineDateApplication.MVC.Model.EF.EF_ActorList;
using OnlineDateApplication.MVC.Model.EF.EF_MovieList;

namespace OnlineDateApplication.MVC.Controllers.Movie
{
    public class MovieController : Controller
    {
        private IDirectorRepository _movieRepository;

        public MovieController(IDirectorRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() => View(_movieRepository.Movies);
    }
}

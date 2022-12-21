using Microsoft.AspNetCore.Mvc;

namespace OnlineDateApplication.MVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

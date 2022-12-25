using Microsoft.AspNetCore.Mvc;

namespace OnlineDateApplication.MVC.Controllers.Director
{
    public class DirectorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

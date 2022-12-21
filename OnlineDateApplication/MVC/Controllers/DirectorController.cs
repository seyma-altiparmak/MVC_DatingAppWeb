using Microsoft.AspNetCore.Mvc;

namespace OnlineDateApplication.MVC.Controllers
{
    public class DirectorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

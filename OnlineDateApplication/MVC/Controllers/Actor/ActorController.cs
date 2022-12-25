using Microsoft.AspNetCore.Mvc;

namespace OnlineDateApplication.MVC.Controllers.Actor
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

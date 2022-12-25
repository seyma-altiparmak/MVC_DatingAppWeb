using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineMovieWebApplication.MVC.Model;
using System.Web.WebPages.Scope;

namespace OnlineDateApplication.MVC.Controllers.User
{
    public class UserController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}

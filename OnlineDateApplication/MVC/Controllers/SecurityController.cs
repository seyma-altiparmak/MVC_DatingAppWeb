using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using OnlineMovieWebApplication.MVC.Model;
using System;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Identity;

namespace OnlineDateApplication.MVC.Controllers
{
    public class SecurityController : Controller
    {
        //Get : Security
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user) {
            //var userInDataBase = Database.User...(x => x.user)
            if(user.UserID != null)
            {
                
            }
            return View(user);
        }
    }
}

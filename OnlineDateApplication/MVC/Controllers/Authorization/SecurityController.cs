using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Identity;
using OnlineDateApplication.MVC.Model.EF.EF_UserList;

namespace OnlineDateApplication.MVC.Controllers.Authorization
{
    public class SecurityController : Controller
    {
        //Get : Security
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            //var userInDataBase = Database.User...(x => x.user)
            if (user.UserID != null)
            {

            }
            return View(user);
        }
    }
}

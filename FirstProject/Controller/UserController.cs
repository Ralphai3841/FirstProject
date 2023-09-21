using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User user = new User();
            user.ID = 1;
            user.FirstName = "Rasim";
            user.LastName = "Demirci";
            return View();
        }

        [NonAction]
        public string GetFullName(User user)   // geri döndürmek
        {
            return user.FirstName + " " + user.LastName;
        }
    }
}

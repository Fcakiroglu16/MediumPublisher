using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomMembership.Controllers
{
    public class UserController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            var claims = User.Claims;

            //Sadece üyelerin görebileceği sayfa
            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult SpecialPage()
        {
            //Sadece admin rolüne sahip olan üyelerin görebileceği sayfa

            return View();
        }
    }
}
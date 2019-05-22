using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace curve_api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult GitHubLogin(string returnUrl = "/")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
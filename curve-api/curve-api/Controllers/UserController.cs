// LEGACY CODE DO NOT USE!!!
// LEGACY CODE DO NOT USE!!!
// LEGACY CODE DO NOT USE!!!


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using curve_api.Models;
//using curve_api.Models.ViewModels;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace curve_api.Controllers
//{
//    [Authorize]
//    public class UserController : Controller
//    {
//        private readonly UserManager<ApplicationUser> _userManager;
//        private readonly SignInManager<ApplicationUser> _signInManager;

//        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }

//        [AllowAnonymous]
//        [HttpGet]
//        public IActionResult Register()
//        {
//            return View();
//        }

//        [AllowAnonymous]
//        [HttpPost]
//        public async Task<IActionResult> Register(RegistrationViewModel rvm)
//        {
//            ApplicationUser user = new ApplicationUser
//            {
//                UserName = rvm.Email,
//                FirstName = rvm.FirstName,
//                LastName = rvm.LastName
//            };

//            var result = await _userManager.CreateAsync(user, rvm.Password);

//            if (result.Succeeded)
//            {
//                await _userManager.AddToRoleAsync(user, ApplicationRoles.User);
//                if (rvm.Email.ToLower().Contains("@codefellows.com"))
//                {
//                    await _userManager.AddToRoleAsync(user, ApplicationRoles.SuperUser);
//                }
//            }

//            await _signInManager.SignInAsync(user, false);

//            if (await _userManager.IsInRoleAsync(user, ApplicationRoles.SuperUser))
//            {
//                await HttpContext.Response.WriteAsync("SuperUser");
//                return Redirect("http://www.google.com");
//            }
//            await HttpContext.Response.WriteAsync("User");
//            return Redirect("http://www.google.com");
//        }

//        [AllowAnonymous]
//        [HttpGet]
//        public IActionResult Login()
//        {
//            return View();
//        }
//    }
//}
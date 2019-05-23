using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curve_api.Models;
using curve_api.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace curve_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IUser _user;

        public AuthorizationController(IUser user)
        {
            _user = user;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetAsync(string email)
        {
            User user = await _user.GetUser(email.ToLower());
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return Ok(await _user.AddUser(email.ToLower()));
            }
        }
    }
}
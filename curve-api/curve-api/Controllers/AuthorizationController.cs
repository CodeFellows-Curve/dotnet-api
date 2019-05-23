using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using curve_api.Models;
using curve_api.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace curve_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IUser _user;
        private readonly IConfiguration _config;

        public AuthorizationController(IUser user, IConfiguration config)
        {
            _user = user;
            _config = config;
        }

        [HttpGet("{email}"), Authorize(AuthenticationSchemes = "Auth0")]
        public async Task<IActionResult> GetAsync(string email)
        {
            User user = await _user.GetUser(email.ToLower()) ??
                await _user.AddUser(email.ToLower());

            return Ok(new {token = GenerateJWT(user)});
        }

        /// <summary>
        /// Generates a JSON Web Token for the given User.
        /// </summary>
        /// <param name="user">The User object used to generate the Token.</param>
        /// <returns>A JSON Web Token as a String.</returns>
        private string GenerateJWT(User user)
        {
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            Claim[] claims = new Claim[]
            {
                new Claim("Key", user.Key),
                new Claim("Role", user.Role)
            };

            JwtSecurityToken token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"], claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
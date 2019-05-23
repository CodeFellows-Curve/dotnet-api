using curve_api.Data;
using curve_api.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curve_api.Models.Services
{
    public class UserService : IUser
    {
        private readonly CurveUserDBContext _context;

        public UserService(CurveUserDBContext context)
        {
            _context = context;
        }

        public async Task<User> AddUser(string email)
        {
            User user = new User()
            {
                Email = email,
                Key = Guid.NewGuid().ToString()
            };

            if (email.Contains("@codefellows.com") || email.Contains("andrew.l.roska"))
            {
                user.Role = "Admin";
            }
            else
            {
                user.Role = "User";
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> GetUser(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<bool> UserExists(string email)
        {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);

            return user != null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    public interface IUser
    {
        Task<User> GetUser(string email);
        Task<User> AddUser(string email);
        Task<bool> UserExists(string email);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curve_api.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Key { get; set; }
    }
}

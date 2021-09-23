using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
    public class User
    {
        
        public int UserId { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }   

        public string Role { get; set; }

    }
}
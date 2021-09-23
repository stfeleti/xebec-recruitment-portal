using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace XebecPortal.Shared
{
    public class LoginHelper
    {
        public int LoginHelperId { get; set; }
        public DateTime TimeDateLogin { get; set; }
        public DateTime TimeDateLogOut { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixHotel.Models
{
    public class UserViewModel
    {
        public Guid Id { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
    }
}

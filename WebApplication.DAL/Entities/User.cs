using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DAL.Entities
{
    public class User
    {
        public Guid Id { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixHotel.Models
{
    public class GuestViewModel
    {
        public Guid Id { set; get; }

        public string FirstName { set; get; }

        public string LastName { set; get; }
        public string Patronic { set; get; }
        public DateTime DayOfBirth { set; get; }

        public int Passport { set; get; }
        public virtual ICollection<LodgingViewModel> Lodgings { get; set; }
    }
}

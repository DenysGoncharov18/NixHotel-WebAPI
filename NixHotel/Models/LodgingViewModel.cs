using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixHotel.Models
{
    public class LodgingViewModel
    {
        public Guid Id { set; get; }
        public Guid GuestId { set; get; }
        public Guid RoomId { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public bool? CheckedIn { set; get; }
        public bool? CheckedOut { set; get; }
        public virtual ICollection<RoomViewModel> Rooms { get; set; }
        public virtual ICollection<GuestViewModel> Guests { get; set; }
    }
}

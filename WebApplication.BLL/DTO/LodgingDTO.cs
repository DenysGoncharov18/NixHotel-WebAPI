using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.BLL.DTO
{
    public class LodgingDTO
    {
        public Guid Id { set; get; }
        public Guid GuestId { set; get; }
        public Guid RoomId { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public bool? CheckedIn { set; get; }
        public bool? CheckedOut { set; get; }
        public virtual ICollection<RoomDTO> Rooms { get; set; }
        public virtual ICollection<GuestDTO> Guests { get; set; }
        public LodgingDTO()
        {
            Id = Guid.NewGuid();
        }
    }
}

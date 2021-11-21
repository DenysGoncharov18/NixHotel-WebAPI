using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DAL.Entities
{
    public class Lodging
    {
        [Key]
        [Required]
        public Guid Id { set; get; }
        public Guid GuestId { set; get; }
        public Guid RoomId { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public bool? CheckedIn { set; get; }
        public bool? CheckedOut { set; get; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
        public Lodging()
        {
            Id = Guid.NewGuid();
        }
    }
}

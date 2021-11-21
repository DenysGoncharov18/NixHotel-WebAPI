using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixHotel.Models
{
    public class CategoryViewModel
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public int Bed { set; get; }
        public virtual ICollection<CategoryDataViewModel> CategoryDates { get; set; }
        public virtual ICollection<RoomViewModel> Rooms { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixHotel.Models
{
    public class RoomViewModel
    {
        public Guid Id { set; get; }
        public int Number { set; get; }
        public Guid CategoryId { set; get; }
        public virtual ICollection<CategoryViewModel> Categories { get; set; }
        public virtual ICollection<LodgingViewModel> Lodgings{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.BLL.DTO
{
    public class RoomDTO
    {
        public Guid Id { set; get; }
        public int Number { set; get; }
        public Guid CategoryId { set; get; }
        public virtual ICollection<CategoryDTO> Categories { get; set; }
        public virtual ICollection<LodgingDTO> Lodgings { get; set; }
        public RoomDTO()
        {
            Id = Guid.NewGuid();
        }
    }
}

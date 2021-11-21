using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.BLL.DTO
{
    public class CategoryDTO
    {

        public Guid Id { set; get; }
        public string Name { set; get; }
        public int Bed { set; get; }
        public virtual ICollection<CategoryDataDTO> CategoryDates { get; set; }
        public virtual ICollection<RoomDTO> Rooms { get; set; }
        public CategoryDTO()
        {
            Id = Guid.NewGuid();
        }
    }
}

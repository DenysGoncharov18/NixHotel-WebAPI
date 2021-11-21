using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DAL.Entities
{
    public class Category
    {
        [Key]
        [Required]
        public Guid Id { set; get; }
        [Required]
        public string Name { set; get; }
        public int Bed { set; get; }
        public virtual ICollection<CategoryData> CategoryDatas { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public Category()
        {
            Id = Guid.NewGuid();
        }
    }
}

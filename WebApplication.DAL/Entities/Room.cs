using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DAL.Entities
{
    public class Room
    {
        [Key]
        [Required]
        public Guid Id { set; get; }
        public int Number { set; get; }
        public Guid CategoryId { set; get; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Lodging> Lodgings { get; set; }
        public Room()
        {
            Id = Guid.NewGuid();
        }
    }
}

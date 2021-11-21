using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DAL.Entities
{
    public class CategoryData
    {

        [Key]
        [Required]
        public Guid Id { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { set; get; }
        public virtual ICollection<Category> Categories { get; set; }
        public CategoryData()
        {
            Id = Guid.NewGuid();
        }
    }
}

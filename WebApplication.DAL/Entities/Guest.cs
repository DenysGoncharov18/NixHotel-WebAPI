using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DAL.Entities
{
    public class Guest
    {
        [Key]
        [Required]
        public Guid Id { set; get; }
        [Required]
        [MaxLength(10)]
        public string FirstName { set; get; }
        [Required]
        [MaxLength(20)]
        public string LastName { set; get; }
        public string Patronic { set; get; }
        public DateTime DayOfBirth { set; get; }
        [Required]
        public int Passport { set; get; }
        public virtual ICollection<Lodging> Lodgings { get; set; }

        public Guest()
        {
            Id = Guid.NewGuid();
        }
    }
}

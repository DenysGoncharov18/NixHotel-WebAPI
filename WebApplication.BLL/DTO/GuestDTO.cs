using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.BLL.DTO
{
    public class GuestDTO
    {
        public Guid Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Patronic { set; get; }
        public DateTime DayOfBirth { set; get; }
        public int Passport { set; get; }
        public virtual ICollection<LodgingDTO> Lodgings { get; set; }

        public GuestDTO()
        {
            Id = Guid.NewGuid();
        }
    }
}

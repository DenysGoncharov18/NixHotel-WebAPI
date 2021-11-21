using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixHotel.Models
{
    public class CategoryDataViewModel
    {
        public Guid Id { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }

        public decimal Price { set; get; }
        public virtual ICollection<CategoryViewModel> Categories { get; set; }
    }
}

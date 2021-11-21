using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DAL.EF;
using WebApplication.DAL.Entities;

namespace WebApplication.DAL.Repositories
{
    class LodgingRepository : Repository<Lodging>
    {
        public LodgingRepository(HotelDbContext context)
            : base(context, context.Lodgings)
        {
            this.db = context;
            this.dbSet = context.Lodgings;
        }
    }
}

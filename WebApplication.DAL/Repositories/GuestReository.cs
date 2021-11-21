using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DAL.EF;
using WebApplication.DAL.Entities;

namespace WebApplication.DAL.Repositories
{
    class GuestRepository : Repository<Guest>
    {
        public GuestRepository(HotelDbContext context)
             : base(context, context.Guests)
        {
            this.db = context;
            this.dbSet = context.Guests;
        }
    }
}

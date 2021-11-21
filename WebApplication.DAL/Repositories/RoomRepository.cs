using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DAL.EF;
using WebApplication.DAL.Entities;

namespace WebApplication.DAL.Repositories
{
    class RoomRepository : Repository<Room>
    {
        public RoomRepository(HotelDbContext context)
             : base(context, context.Rooms)
        {
            this.db = context;
            this.dbSet = context.Rooms;
        }
    }
}

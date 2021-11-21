using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DAL.Entities;

namespace WebApplication.DAL.Interfaces
{
    public interface IHotelUW : IDisposable
    {
        IRepository<Guest> Guests { get; }
        IRepository<Lodging> Lodgings { get; }
        IRepository<Room> Rooms { get; }
        IRepository<Category> Categories { get; }
        IRepository<CategoryData> CategoryDatas { get; }
        IRepository<User> Users { get; }
        void Save();
    }
}

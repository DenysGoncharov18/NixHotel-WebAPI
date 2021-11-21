using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BLL.DTO;

namespace WebApplication.BLL.Interfaces
{
    public interface IRoomService : IDisposable
    {
        void Create(RoomDTO item);
        RoomDTO Get(Guid id);
        IEnumerable<RoomDTO> Get();
        void Update(RoomDTO item);
        void Delete(Guid id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BLL.DTO;

namespace WebApplication.BLL.Interfaces
{
    public interface ILodgingService : IDisposable
    {
        void Create(LodgingDTO item);
        LodgingDTO Get(Guid id);
        IEnumerable<LodgingDTO> Get();
        void Update(LodgingDTO item);
        void Delete(Guid id);
    }
}

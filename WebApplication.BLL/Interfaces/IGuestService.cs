using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BLL.DTO;

namespace WebApplication.BLL.Interfaces
{
    public interface IGuestService : IDisposable
    {
        void Create(GuestDTO item);
        GuestDTO Get(Guid id);
        IEnumerable<GuestDTO> Get();
        void Update(GuestDTO item);
        void Delete(Guid id);
    }
}

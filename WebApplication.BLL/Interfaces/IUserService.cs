using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BLL.DTO;

namespace WebApplication.BLL.Interfaces
{
    public interface IUserService : IDisposable
    {
        void Create(UserDTO item);
        UserDTO Get(Guid id);
        IEnumerable<UserDTO> Get();
        void Update(UserDTO item);
        void Delete(Guid id);
    }
}

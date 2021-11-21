using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BLL.DTO;

namespace WebApplication.BLL.Interfaces
{
    public interface ICategoryService : IDisposable
    {
        void Create(CategoryDTO item);
        CategoryDTO Get(Guid id);
        IEnumerable<CategoryDTO> Get();
        void Update(CategoryDTO item);
        void Delete(Guid id);
    }
}

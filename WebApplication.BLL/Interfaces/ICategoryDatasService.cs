using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BLL.DTO;

namespace WebApplication.BLL.Interfaces
{
    public interface ICategoryDataService : IDisposable
    {
        void Create(CategoryDataDTO item);
        CategoryDataDTO Get(Guid id);
        IEnumerable<CategoryDataDTO> Get();
        void Update(CategoryDataDTO item);
        void Delete(Guid id);
    }
}

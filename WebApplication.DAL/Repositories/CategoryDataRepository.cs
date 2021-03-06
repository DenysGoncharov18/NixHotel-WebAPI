using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DAL.EF;
using WebApplication.DAL.Entities;

namespace WebApplication.DAL.Repositories
{
    class CategoryDataRepository : Repository<CategoryData>
    {
        public CategoryDataRepository(HotelDbContext context)
            : base(context, context.CategoryDatas)
        {
            this.db = context;
            this.dbSet = context.CategoryDatas;
        }

    }
}

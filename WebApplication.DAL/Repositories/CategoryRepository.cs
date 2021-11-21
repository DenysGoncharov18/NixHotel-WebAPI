using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DAL.EF;
using WebApplication.DAL.Entities;

namespace WebApplication.DAL.Repositories
{
    class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(HotelDbContext context)
            : base(context, context.Categories)
        {
            this.db = context;
            this.dbSet = context.Categories;
        }
    }
}

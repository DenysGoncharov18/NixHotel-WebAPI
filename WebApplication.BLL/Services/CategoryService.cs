using System;
using System.Collections.Generic;
using AutoMapper;
using WebApplication.DAL.Interfaces;
using WebApplication.BLL.DTO;
using WebApplication.DAL.Entities;
using WebApplication.BLL.Interfaces;

namespace WebApplication.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        IHotelUW db;
        public CategoryService(IHotelUW db)
        {
            this.db = db;
        }

        public void Create(CategoryDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, Category>()).CreateMapper();

            db.Categories.Create(mapper.Map<CategoryDTO, Category>(item));
        }
        public CategoryDTO Get(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();

            return mapper.Map<Category, CategoryDTO>(db.Categories.Get(id));
        }
        public IEnumerable<CategoryDTO> Get()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(db.Categories.GetAll());
        }

        public void Update(CategoryDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, Category>()).CreateMapper();
            db.Categories.Update(mapper.Map<CategoryDTO, Category>(item));
        }

        public void Delete(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, Category>()).CreateMapper();
            db.Categories.Delete(id: mapper.Map<CategoryDTO, Category>(Get(id)).Id);
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}




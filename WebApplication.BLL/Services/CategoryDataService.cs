using System;
using System.Collections.Generic;
using AutoMapper;
using WebApplication.DAL.Interfaces;
using WebApplication.BLL.DTO;
using WebApplication.DAL.Entities;
using WebApplication.BLL.Interfaces;

namespace WebApplication.BLL.Services
{
    public class CategoryDataService : ICategoryDataService
    {
        IHotelUW db;
        public CategoryDataService(IHotelUW db)
        {
            this.db = db;
        }

        public void Create(CategoryDataDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDataDTO, CategoryData>()).CreateMapper();

            db.CategoryDatas.Create(mapper.Map<CategoryDataDTO, CategoryData>(item));
        }
        public CategoryDataDTO Get(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryData, CategoryDataDTO>()).CreateMapper();

            return mapper.Map<CategoryData, CategoryDataDTO>(db.CategoryDatas.Get(id));
        }
        public IEnumerable<CategoryDataDTO> Get()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryData, CategoryDataDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<CategoryData>, List<CategoryDataDTO>>(db.CategoryDatas.GetAll());
        }

        public void Update(CategoryDataDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDataDTO, CategoryData>()).CreateMapper();
            db.CategoryDatas.Update(mapper.Map<CategoryDataDTO, CategoryData>(item));
        }

        public void Delete(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDataDTO, CategoryData>()).CreateMapper();
            db.CategoryDatas.Delete(id: mapper.Map<CategoryDataDTO, CategoryData>(Get(id)).Id);
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}

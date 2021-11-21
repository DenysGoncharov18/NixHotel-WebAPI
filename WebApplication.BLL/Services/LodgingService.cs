using System;
using System.Collections.Generic;
using AutoMapper;
using WebApplication.DAL.Interfaces;
using WebApplication.BLL.DTO;
using WebApplication.DAL.Entities;
using WebApplication.BLL.Interfaces;

namespace WebApplication.BLL.Services
{
    public class LodgingService : ILodgingService
    {
        IHotelUW db;
        public LodgingService(IHotelUW db)
        {
            this.db = db;
        }

        public void Create(LodgingDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<LodgingDTO, Lodging>()).CreateMapper();

            db.Lodgings.Create(mapper.Map<LodgingDTO, Lodging>(item));
        }
        public LodgingDTO Get(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Lodging, LodgingDTO>()).CreateMapper();

            return mapper.Map<Lodging, LodgingDTO>(db.Lodgings.Get(id));
        }
        public IEnumerable<LodgingDTO> Get()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Lodging, LodgingDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Lodging>, List<LodgingDTO>>(db.Lodgings.GetAll());
        }

        public void Update(LodgingDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<LodgingDTO, Lodging>()).CreateMapper();
            db.Lodgings.Update(mapper.Map<LodgingDTO, Lodging>(item));
        }

        public void Delete(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<LodgingDTO, Lodging>()).CreateMapper();
            db.Lodgings.Delete(mapper.Map<LodgingDTO, Lodging>(Get(id)).Id);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

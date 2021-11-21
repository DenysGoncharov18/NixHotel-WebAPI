using System;
using System.Collections.Generic;
using AutoMapper;
using WebApplication.DAL.Interfaces;
using WebApplication.BLL.DTO;
using WebApplication.DAL.Entities;
using WebApplication.BLL.Interfaces;

namespace WebApplication.BLL.Services
{
    public class GuestService : IGuestService
    {
        IHotelUW db;
        public GuestService(IHotelUW db)
        {
            this.db = db;
        }

        public void Create(GuestDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GuestDTO, Guest>()).CreateMapper();

            db.Guests.Create(mapper.Map<GuestDTO, Guest>(item));
        }
        public GuestDTO Get(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Guest, GuestDTO>()).CreateMapper();

            return mapper.Map<Guest, GuestDTO>(db.Guests.Get(id));
        }
        public IEnumerable<GuestDTO> Get()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Guest, GuestDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Guest>, List<GuestDTO>>(db.Guests.GetAll());
        }

        public void Update(GuestDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GuestDTO, Guest>()).CreateMapper();
            db.Guests.Update(mapper.Map<GuestDTO, Guest>(item));
        }

        public void Delete(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GuestDTO, Guest>()).CreateMapper();
            db.Guests.Delete(mapper.Map<GuestDTO, Guest>(Get(id)).Id);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using AutoMapper;
using WebApplication.DAL.Interfaces;
using WebApplication.BLL.DTO;
using WebApplication.DAL.Entities;
using WebApplication.BLL.Interfaces;

namespace WebApplication.BLL.Services
{
    public class RoomService : IRoomService
    {
        IHotelUW db;
        public RoomService(IHotelUW db)
        {
            this.db = db;
        }

        public void Create(RoomDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<RoomDTO, Room>()).CreateMapper();

            db.Rooms.Create(mapper.Map<RoomDTO, Room>(item));
        }
        public RoomDTO Get(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomDTO>()).CreateMapper();

            return mapper.Map<Room, RoomDTO>(db.Rooms.Get(id));
        }
        public IEnumerable<RoomDTO> Get()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Room>, List<RoomDTO>>(db.Rooms.GetAll());
        }

        public void Update(RoomDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<RoomDTO, Room>()).CreateMapper();
            db.Rooms.Update(mapper.Map<RoomDTO, Room>(item));
        }

        public void Delete(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<RoomDTO, Room>()).CreateMapper();
            db.Rooms.Delete(mapper.Map<RoomDTO, Room>(Get(id)).Id);
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}

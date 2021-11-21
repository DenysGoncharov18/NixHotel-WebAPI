using System;
using System.Collections.Generic;
using AutoMapper;
using WebApplication.DAL.Interfaces;
using WebApplication.BLL.DTO;
using WebApplication.DAL.Entities;
using WebApplication.BLL.Interfaces;

namespace WebApplication.BLL.Services
{
    public class UserService : IUserService
    {
        IHotelUW db;
        public UserService(IHotelUW db)
        {
            this.db = db;
        }

        public void Create(UserDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>()).CreateMapper();

            db.Users.Create(mapper.Map<UserDTO, User>(item));
        }
        public UserDTO Get(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();

            return mapper.Map<User, UserDTO>(db.Users.Get(id));
        }
        public IEnumerable<UserDTO> Get()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<User>, List<UserDTO>>(db.Users.GetAll());
        }

        public void Update(UserDTO item)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>()).CreateMapper();
            db.Users.Update(mapper.Map<UserDTO, User>(item));
        }

        public void Delete(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>()).CreateMapper();
            db.Rooms.Delete(mapper.Map<UserDTO, User>(Get(id)).Id);
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}

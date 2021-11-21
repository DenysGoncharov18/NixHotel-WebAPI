using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NixHotel.Models;
using AutoMapper;
using WebApplication.BLL.DTO;
using WebApplication.BLL.Interfaces;

namespace NixHotel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        private IMapper GetMapper()
        {
            return new MapperConfiguration(cfg =>
                 cfg.CreateMap<UserDTO, UserViewModel>()).CreateMapper();
        }

        [HttpPost]
        public void Post(UserViewModel item)
        {
            service.Create(new UserDTO());
            {
                service.Create(GetMapper().Map<UserViewModel, UserDTO>(item));
            }
        }
        [HttpGet]
        public UserViewModel Get(Guid id)
        {
            return GetMapper().Map<UserDTO, UserViewModel>(service.Get(id));
        }
        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return GetMapper().Map<IEnumerable<UserDTO>, List<UserViewModel>>(service.Get());
        }
        [HttpPut]
        public void Put(UserViewModel item)//update
        {
            service.Update(GetMapper().Map<UserViewModel, UserDTO>(item));
        }
        [HttpDelete]
        public void Delete(Guid id)
        {
            service.Delete(GetMapper().Map<UserViewModel, UserDTO>(Get(id)).Id);
        }
    }
}

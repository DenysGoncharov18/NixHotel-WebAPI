using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NixHotel.Models;
using WebApplication.BLL.DTO;
using WebApplication.BLL.Interfaces;
using AutoMapper;

namespace NixHotel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private IRoomService service;

        public RoomController(IRoomService service)
        {
            this.service = service;
        }

        private IMapper GetMapper()
        {
            return new MapperConfiguration(cfg =>
                cfg.CreateMap<RoomDTO, RoomViewModel>()).CreateMapper();
        }

        [HttpPost]
        public void Post(RoomViewModel item)
        {
            service.Create(new RoomDTO());
            {
                service.Create(GetMapper().Map<RoomViewModel, RoomDTO>(item)); //Инициализация обекта 
            }

        }
        [HttpGet]
        public RoomViewModel Get(Guid id)
        {
            return GetMapper().Map<RoomDTO, RoomViewModel>(service.Get(id));
        }
        [HttpGet]
        public IEnumerable<RoomViewModel> Get()
        {
            return GetMapper().Map<IEnumerable<RoomDTO>, List<RoomViewModel>>(service.Get());
        }
        [HttpPut]
        public void Put(RoomViewModel item)//update
        {
            service.Update(GetMapper().Map<RoomViewModel, RoomDTO>(item));
        }
        [HttpDelete]
        public void Delete(Guid id)
        {
            service.Delete(GetMapper().Map<RoomViewModel, RoomDTO>(Get(id)).Id);
        }
    }
}

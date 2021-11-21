using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using WebApplication.BLL.DTO;
using WebApplication.BLL.Interfaces;
using NixHotel.Models;

namespace NixHotel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private IGuestService service;

        public GuestController(IGuestService service)
        {
            this.service = service;
        }

        private IMapper GetMapper()
        {
            return new MapperConfiguration(cfg =>
                 cfg.CreateMap<GuestDTO, GuestViewModel>()).CreateMapper();
        }

        [HttpPost]
        public void Post(GuestViewModel item)
        {
            service.Create(new GuestDTO());
            {
                service.Create(GetMapper().Map<GuestViewModel, GuestDTO>(item));
            }
        }
        [HttpGet]
        public GuestViewModel Get(Guid id)
        {
            return GetMapper().Map<GuestDTO, GuestViewModel>(service.Get(id));
        }
        [HttpGet]
        public IEnumerable<GuestViewModel> Get()
        {
            return GetMapper().Map<IEnumerable<GuestDTO>, List<GuestViewModel>>(service.Get());
        }
        [HttpPut]
        public void Put(GuestViewModel item)//update
        {
            service.Update(GetMapper().Map<GuestViewModel, GuestDTO>(item));
        }
        [HttpDelete]
        public void Delete(Guid id)
        {
            service.Delete(GetMapper().Map<GuestViewModel, GuestDTO>(Get(id)).Id);
        }
    }
}

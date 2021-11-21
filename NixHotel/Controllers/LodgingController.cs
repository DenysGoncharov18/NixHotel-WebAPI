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
    public class LodgingController : ControllerBase
    {
        private ILodgingService service;

        public LodgingController(ILodgingService service)
        {
            this.service = service;
        }

        private IMapper GetMapper()
        {
            return new MapperConfiguration(cfg =>
                 cfg.CreateMap<LodgingDTO, LodgingViewModel>()).CreateMapper();
        }

        [HttpPost]
        public void Post(LodgingViewModel item)
        {
            service.Create(new LodgingDTO());
            {
                service.Create(GetMapper().Map<LodgingViewModel, LodgingDTO>(item));
            }
        }
        [HttpGet]
        public LodgingViewModel Get(Guid id)
        {
            return GetMapper().Map<LodgingDTO, LodgingViewModel>(service.Get(id));
        }
        [HttpGet]
        public IEnumerable<LodgingViewModel> Get()
        {
            return GetMapper().Map<IEnumerable<LodgingDTO>, List<LodgingViewModel>>(service.Get());
        }
        [HttpPut]
        public void Put(LodgingViewModel item)//update
        {
            service.Update(GetMapper().Map<LodgingViewModel, LodgingDTO>(item));
        }
        [HttpDelete]
        public void Delete(Guid id)
        {
            service.Delete(GetMapper().Map<LodgingViewModel, LodgingDTO>(Get(id)).Id);
        }
    }
}

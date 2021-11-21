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
    public class CategoryDataController : ControllerBase
    {
        private ICategoryDataService service;

        public CategoryDataController(ICategoryDataService service)
        {
            this.service = service;
        }

        private IMapper GetMapper()
        {
            return new MapperConfiguration(cfg =>
                cfg.CreateMap<CategoryDataDTO, CategoryDataViewModel>()).CreateMapper();
        }

        [HttpPost]
        public void Post(CategoryDataViewModel item)
        {
            service.Create(new CategoryDataDTO());
            {
                service.Create(GetMapper().Map<CategoryDataViewModel, CategoryDataDTO>(item)); //Инициализация обекта 
            }
        }
        [HttpGet]
        public CategoryDataViewModel Get(Guid id)
        {
            return GetMapper().Map<CategoryDataDTO, CategoryDataViewModel>(service.Get(id));
        }
        [HttpGet]
        public IEnumerable<CategoryDataViewModel> Get()
        {
            return GetMapper().Map<IEnumerable<CategoryDataDTO>, List<CategoryDataViewModel>>(service.Get());
        }
        [HttpPut]
        public void Put(CategoryDataViewModel item)//update
        {
            service.Update(GetMapper().Map<CategoryDataViewModel, CategoryDataDTO>(item));
        }
        [HttpDelete]
        public void Delete(Guid id)
        {
            service.Delete(GetMapper().Map<CategoryDataViewModel, CategoryDataDTO>(Get(id)).Id);
        }
    }
}

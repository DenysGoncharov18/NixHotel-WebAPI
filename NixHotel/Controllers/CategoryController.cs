using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NixHotel.Models;
using System;
using System.Collections.Generic;
using AutoMapper;
using WebApplication.BLL.DTO;
using WebApplication.BLL.Interfaces;

namespace NixHotel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }

        private IMapper GetMapper()
        {
            return new MapperConfiguration(cfg =>
                cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
        }

        [HttpPost]
        public void Post(CategoryViewModel item)
        {
            service.Create(new CategoryDTO());
            {
                service.Create(GetMapper().Map<CategoryViewModel, CategoryDTO>(item)); //Инициализация обекта 
            }
        }
        [HttpGet]
        public CategoryViewModel Get(Guid id)
        {
            return GetMapper().Map<CategoryDTO, CategoryViewModel>(service.Get(id));
        }
        [HttpGet]
        public IEnumerable<CategoryViewModel> Get()
        {
            return GetMapper().Map<IEnumerable<CategoryDTO>, List<CategoryViewModel>>(service.Get());
        }
        [HttpPut]
        public void Put(CategoryViewModel item)//update
        {
            service.Update(GetMapper().Map<CategoryViewModel, CategoryDTO>(item));
        }
        [HttpDelete]
        public void Delete(Guid id)
        {
            service.Delete(GetMapper().Map<CategoryViewModel, CategoryDTO>(Get(id)).Id);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Domain.Interfaces;
using Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemCRUDService _service;
        public ItemController(IItemCRUDService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
           return _service.ReadItem().ToList();
        }

        //[HttpGet]
        //public string GetP()
        //{
        //    return "111";
        //}
    }
}

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

        }
        public ActionResult<List<Item>> GetItem()
        {
           return _service.ReadItem();
        }
    }
}

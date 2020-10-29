using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceCatalog.DbContexts;
using ServiceCatalog.Entities;
using ServiceCatalog.Repositories;

namespace ServiceCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceItemController : ControllerBase
    {
        private readonly IServiceItemRepository _repository;

        public ServiceItemController(IServiceItemRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<IEnumerable<ServiceItem>>> GetServiceItems(Guid categoryId)
        {
            var result = await _repository.GetServiceItems(categoryId);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceItem>> GetServiceItemById(int id)
        {
            var result = await _repository.GetServiceItemById(id);
            return Ok(result);
        }
    }
}
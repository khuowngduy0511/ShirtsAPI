using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Filters;
using api.models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok("Reading all the shirts");
        }
        
        [HttpGet ("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtsById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
        }

        [HttpPost]
        public IActionResult CreateShirt([FromBody] Shirt shirt)
        {
            return Ok("Creating a shirt");
        }

        [HttpPut ("{id}")]
        public IActionResult UpdateShirtById(int id)
        {
            return Ok("Updating shirt: {id}");
        }

        [HttpDelete ("{id}")]
        public IActionResult DeleteShirtById(int id)
        {
            return Ok("Deleting Shirt: {id}");
        }
    }
}
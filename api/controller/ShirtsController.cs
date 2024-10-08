using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }
        
        [HttpGet ("{id}")]
        public string GetShirtsById(int id)
        {
            return $"Reading shirt: {id}";
        }

        [HttpPost]
        public string CreateShirt([FromBody] Shirt shirt)
        {
            return $"Creating a shirt";
        }

        [HttpPut ("{id}")]
        public string UpdateShirtById(int id)
        {
            return $"Updating shirt: {id}";
        }

        [HttpDelete ("{id}")]
        public string DeleteShirtById(int id)
        {
            return $"Deleting Shirt: {id}";
        }
    }
}
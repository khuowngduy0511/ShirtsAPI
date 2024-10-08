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
        private List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtID = 1, Brand = "My Brand", Color = "Red", Gender = "Men", Price = 30, Size = 9},
            new Shirt {ShirtID = 2, Brand = "My Brand", Color = "Blue", Gender = "Men", Price = 35, Size = 10},
            new Shirt {ShirtID = 3, Brand = "Your Brand", Color = "Black", Gender = "Women", Price = 29.5, Size = 8},
            new Shirt {ShirtID = 4, Brand = "Your Brand", Color = "Pink", Gender = "Women", Price = 37, Size = 6}
        };

        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok("Reading all the shirts");
        }
        
        [HttpGet ("{id}")]
        public IActionResult GetShirtsById(int id)
        {
            if(id <= 0)
            {
                return BadRequest ();
            }

            var shirt = shirts.FirstOrDefault(x => x.ShirtID == id);
            if (shirt == null)
            {
                return NotFound();
            }

            return Ok(shirt);
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
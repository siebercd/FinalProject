using FinalProj.Interfaces;
using FinalProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Food_Controller : ControllerBase
    {
        private readonly ILogger<Food_Controller> _logger;
        private readonly IGroup_Context_DAO _context;

        public Food_Controller(ILogger<Food_Controller> logger, IGroup_Context_DAO context)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllFoods());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var food = _context.GetFoodById(id);
            if (food == null)
            {
                return Ok(_context.GetAllFoods());
            }
            else
            {
                return Ok(food);
            }
        }

        [HttpDelete]
        public IActionResult Remove(int id)
        {
            var result = _context.RemoveFoodById(id);
            if (result == null)
            {
                return NotFound(id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            else
            {
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult Put(FavFood food)
        {
            var result = _context.UpdateFood(food);
            if (result == null)
            {
                return NotFound(food.Id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request.");
            }
            else
            {
                return Ok();
            }
        }

        [HttpPost]
        public IActionResult Post(FavFood food)
        {
            var result = _context.AddFood(food);
            if (result == null)
            {
                return StatusCode(500, "Food already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            else
            {
                return Ok();
            }
        }
    }
}

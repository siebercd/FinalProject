using FinalProj.Data;
using FinalProj.Interfaces;
using FinalProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace CRFinal_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class Group_Hobbies_Controller : ControllerBase
    {
        private readonly ILogger<Group_Hobbies_Controller> _logger;

        private readonly IGroup_Context_DAO _context;

        public Group_Hobbies_Controller(ILogger<Group_Hobbies_Controller> logger, IGroup_Context_DAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllHobbies());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var hobby = _context.GetHobbyById(id);
            if (hobby == null)
            {
                return Ok(_context.GetAllHobbies());
            }
            else
            {
                return Ok(hobby);
            }
        }

        [HttpDelete]
        public IActionResult Remove(int id)
        {
            var result = _context.DeleteHobbyById(id);
            if (result == null)
            {
                return NotFound(id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            else
                return Ok();
        }

        [HttpPut]
        public IActionResult Put(Group_Hobbies hobby)
        {
            var result = _context.UpdateHobbyById(hobby);
            if (result == null)
            {
                return NotFound(hobby.Id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            else
                return Ok();
        }

        [HttpPost]
        public IActionResult Post(Group_Hobbies hobby)
        {
            var result = _context.UpdateHobbyById(hobby);
            if (result == null)
            {
                return StatusCode(500, "Hobby already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            else
                return Ok();
        }
    }
}
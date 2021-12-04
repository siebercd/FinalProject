using FinalProj.Data;
using FinalProj.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace FinalProj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Group_Members_Controller : ControllerBase
    {
        private readonly ILogger<Group_Members_Controller> _logger;

        private readonly IGroup_Context_DAO _context;

        public Group_Members_Controller(ILogger<Group_Members_Controller> logger, IGroup_Context_DAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllMembers());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var member = _context.GetMemberById(id);
            if (member == null)
            {
                return Ok(_context.GetAllMembers());
            }
            else
            {
                return Ok(member);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveMemberById(id);
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
        public IActionResult Put(Group_Members member)
        {
            var result = _context.UpdateMember(member);
            if (result == null)
            {
                return NotFound(member.Id);
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

        [HttpPost]
        public IActionResult Post(Group_Members member)
        {
           var result = _context.Add(member);
            if (result == null)
            {
                return StatusCode(500, "Member already exists");
            }
            if (result ==0)
            {
                return StatusCode(500, "An error occurred while processing your request");

            }
            else
            {
                return Ok();
            }

        }
    }
}

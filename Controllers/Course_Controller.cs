using FinalProj.Data;
using FinalProj.Interfaces;
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
    public class Course_Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<Course_Controller> _logger;

        private readonly IGroup_Context_DAO course_context;

        public Course_Controller(ILogger<Course_Controller> logger, IGroup_Context_DAO context)
        {
            _logger = logger;
            course_context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(course_context.GetAllCourses());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var course = course_context.GetCourseByID(id);
            if (course == null)
            {
                return Ok(course_context.GetAllCourses());
            }
            else
            {
                return Ok(course);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = course_context.RemoveCourseByID(id);
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
        public IActionResult Put(Course course)
        {
            var result = course_context.UpdateCourse(course);
            if (result == null)
            {
                return NotFound(course.Id);
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
        public IActionResult Post(Course course)
        {
            var result = course_context.Add(course);
            if (result == null)
            {
                return StatusCode(500, "Member already exists");
            }
            if (result == 0)
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

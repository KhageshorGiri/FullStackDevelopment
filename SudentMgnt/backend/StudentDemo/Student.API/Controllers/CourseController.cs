﻿using Microsoft.AspNetCore.Mvc;
using Student.Application.Dtos;
using Student.Application.Interfaces.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourse courseService;

        public CourseController(ICourse course)
        {
            this.courseService = course;
        }

        // GET: api/<CourseController>
        [HttpGet]
        public  async Task<List<CourseDto>> Get()
        {
            return await courseService.GetAllCOursesAsync();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public async Task<CourseDto> Get(Guid id)
        {
            return await courseService.GetCourseByIdAsync(id);
        }

        // POST api/<CourseController>
        [HttpPost]
        public async Task Post([FromBody] CreateCourseDto newCourse)
        {
            await courseService.AddCourseAsync(newCourse);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

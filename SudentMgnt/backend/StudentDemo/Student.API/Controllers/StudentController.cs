using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Student.Application.Dtos;
using Student.Application.Interfaces.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent studentService;
        //private readonly ILogger _logger;

        public StudentController(IStudent student, IMapper mapper)
        {
            studentService = student;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IEnumerable<StudentDto>> Get()
        {
            //_logger.LogInformation("Student Contrller,");
            var response = await studentService.GetAllStudentsAsync();
            return response.ToList();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var existingStudent = await studentService.GetStudentByIdAsync(id);
            if(existingStudent == null)
            {
                return NotFound();
            }
            return Ok(existingStudent);
        }

        // POST api/<StudentController>
        [HttpPost]
        public async void Post([FromBody] CreateStudentDto newStudent)
        {
            await studentService.AddStudentAsync(newStudent);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(Guid Id, [FromBody] UpdateStudentDto existingStudent)
        {
            var student = await studentService.GetStudentByIdAsync(Id);
            if (student == null)
            {
                return NotFound();
            }
            await studentService.UpdateStudentAsync(Id, existingStudent);
            return Ok();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(Guid Id)
        {
            var student = await studentService.GetStudentByIdAsync(Id);
            if (student == null)
            {
                return NotFound();
            }
            await studentService.DeleteStudentAsync(Id);
            return Ok();
        }
    }
}

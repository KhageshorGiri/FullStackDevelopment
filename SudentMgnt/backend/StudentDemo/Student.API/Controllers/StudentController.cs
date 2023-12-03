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
        private readonly ILogger _logger;

        public StudentController(IStudent student, ILogger logger)
        {
            studentService = student;
            _logger = logger;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IEnumerable<StudentDto>> Get()
        {
            throw new NotImplementedException();

           /* _logger.LogInformation("Student Contrller,");
            var response = await studentService.GetAllStudentsAsync();
            return response.ToList();*/
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

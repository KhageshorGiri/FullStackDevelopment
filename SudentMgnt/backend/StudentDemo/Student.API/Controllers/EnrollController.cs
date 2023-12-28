using Microsoft.AspNetCore.Mvc;
using Student.Application.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollController : ControllerBase
    {
        // GET: api/<EnrollController>
        [HttpGet]
        public Task<IEnumerable<EnrollDto>> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<EnrollController>/5
        [HttpGet("{id}")]
        public Task<EnrollDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        // POST api/<EnrollController>
        [HttpPost]
        public Task<IActionResult> Post([FromBody] EnrollStudentDto newEnroll)
        {
            throw new NotImplementedException();
        }

        // PUT api/<EnrollController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] UpdateEnrollDto existingEnroll)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<EnrollController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

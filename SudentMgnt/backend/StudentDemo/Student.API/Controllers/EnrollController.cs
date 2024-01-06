using Microsoft.AspNetCore.Mvc;
using Student.Application.Dtos;
using Student.Application.Interfaces.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollController : ControllerBase
    {
        protected readonly IEnroll _enrollService;

        public EnrollController(IEnroll enroll)
        {
            _enrollService = enroll;
        }


        // GET: api/<EnrollController>
        [HttpGet]
        public async Task<IEnumerable<EnrollDto>> Get()
        {
           return await _enrollService.GetAllEnrollListAsync();
        }

        // GET api/<EnrollController>/5
        [HttpGet("{id}")]
        public async Task<EnrollDto> Get(Guid id)
        {
            return await _enrollService.GetEnrollByIdAsync(id);
        }

        // POST api/<EnrollController>
        [HttpPost]
        public async Task Post([FromBody] EnrollStudentDto newEnroll)
        {
            await _enrollService.AddEnrollAsync(newEnroll);
        }

        // PUT api/<EnrollController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateEnrollDto existingEnroll)
        {
            var existing = await _enrollService.GetEnrollByIdAsync(id);
            if(existing == null)
            {
                return NoContent();
            }
            await _enrollService.UpdateEnrollAsync(id, existingEnroll);
            return Ok();
        }

        // DELETE api/<EnrollController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var existing = await _enrollService.GetEnrollByIdAsync(id);
            if (existing == null)
            {
                return NoContent();
            }
            await _enrollService.DeleteEnrollAsync(id);
            return Ok();
        }
    }
}

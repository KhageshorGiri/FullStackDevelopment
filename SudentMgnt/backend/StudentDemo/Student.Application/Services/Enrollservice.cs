using Student.Application.Dtos;
using Student.Application.Interfaces.ServiceInterfaces;

namespace Student.Application.Services
{
    public class Enrollservice : IEnroll
    {
        public Task AddEnrollAsync(EnrollStudentDto course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEnrollAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EnrollDto>> GetAllEnrollListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EnrollDto> GetEnrollByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEnrollAsync(Guid Id, UpdateEnrollDto course)
        {
            throw new NotImplementedException();
        }
    }
}

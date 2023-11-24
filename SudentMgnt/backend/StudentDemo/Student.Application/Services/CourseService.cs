using Student.Application.Dtos;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Entities.Entities;

namespace Student.Application.Services
{
    public class CourseService : ICourse
    {
        public Task AddCourseAsync(CreateCourseDto course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourseAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseDto>> GetAllCOursesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CourseDto> GetCourseByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(UpdateCourseDto course)
        {
            throw new NotImplementedException();
        }
    }
}

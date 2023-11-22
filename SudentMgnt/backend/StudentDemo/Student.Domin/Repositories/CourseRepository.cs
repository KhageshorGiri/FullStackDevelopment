using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Entities.Entities;

namespace Student.Domin.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public Task AddCourseAsync(Courses course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourseAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Students>> GetAllCOursesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Students> GetCourseByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(Courses course)
        {
            throw new NotImplementedException();
        }
    }
}

using Student.Entities.Entities;

namespace Student.Application.Interfaces.ServiceInterfaces
{
    public interface ICourseRepository
    {
        Task<List<Students>> GetAllCOursesAsync();
        Task<Students> GetCourseByIdAsync(Guid Id);
        Task AddCourseAsync(Courses course);
        Task UpdateCourseAsync(Courses course);
        Task DeleteCourseAsync(Guid Id);
    }
}

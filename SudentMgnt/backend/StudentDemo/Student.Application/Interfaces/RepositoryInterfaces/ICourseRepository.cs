using Student.Entities.Entities;

namespace Student.Application.Interfaces.RepositoryInterfaces
{
    public interface ICourseRepository
    {
        Task<List<Courses>> GetAllCOursesAsync();
        Task<Courses> GetCourseByIdAsync(Guid Id);
        Task AddCourseAsync(Courses course);
        Task UpdateCourseAsync(Guid Id, Courses course);
        Task DeleteCourseAsync(Guid Id);
    }
}

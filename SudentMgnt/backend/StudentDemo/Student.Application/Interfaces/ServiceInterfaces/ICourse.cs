using Student.Application.Dtos;
using Student.Entities.Entities;

namespace Student.Application.Interfaces.ServiceInterfaces
{
    public interface ICourse
    {
        Task<List<CourseDto>> GetAllCOursesAsync();
        Task<CourseDto> GetCourseByIdAsync(Guid Id);
        Task AddCourseAsync(CreateCourseDto course);
        Task UpdateCourseAsync(UpdateCourseDto course);
        Task DeleteCourseAsync(Guid Id);
    }
}

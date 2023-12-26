using Student.Application.Dtos;
using Student.Entities.Entities;

namespace Student.Application.Interfaces.ServiceInterfaces
{
    public interface IStudent
    {
        Task<List<StudentDto>> GetAllStudentsAsync();
        Task<StudentDto> GetStudentByIdAsync(Guid Id);
        Task AddStudentAsync(CreateStudentDto student);
        Task UpdateStudentAsync(UpdateStudentDto student);
        Task DeleteStudentAsync(Guid Id);
    }
}

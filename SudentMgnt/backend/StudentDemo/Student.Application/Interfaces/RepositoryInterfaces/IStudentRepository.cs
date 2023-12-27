using Student.Entities.Entities;

namespace Student.Application.Interfaces.RepositoryInterfaces
{
    public interface IStudentRepository
    {
        Task<List<Students>> GetAllStudentsAsync();
        Task<Students> GetStudentByIdAsync(Guid Id);
        Task AddStudentAsync(Students student);
        Task UpdateStudentAsync(Guid Id, Students student);
        Task DeleteStudentAsync(Guid Id);
    }
}

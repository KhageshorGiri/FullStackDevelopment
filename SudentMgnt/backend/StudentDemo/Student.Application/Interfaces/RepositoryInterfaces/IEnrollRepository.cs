using Student.Entities.Entities;

namespace Student.Application.Interfaces.RepositoryInterfaces
{
    public interface IEnrollRepository
    {
        Task<List<Enroll>> GetAllEnrollListAsync();
        Task<Enroll> GetEnrollByIdAsync(Guid Id);
        Task AddEnrollAsync(Enroll course);
        Task UpdateEnrollAsync(Guid Id, Enroll course);
        Task DeleteEnrollAsync(Guid Id);
    }
}

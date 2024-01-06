using Student.Entities.Entities;

namespace Student.Application.Interfaces.RepositoryInterfaces
{
    public interface IEnrollRepository
    {
        Task<List<Enroll>> GetAllAsync();
        Task<Enroll> GetEnrollByIdAsync(Guid Id);
        Task AddAsync(Enroll enroll);
        Task UpdateAsync(Enroll enroll);
        Task DeleteAsync(Enroll enroll);
    }
}

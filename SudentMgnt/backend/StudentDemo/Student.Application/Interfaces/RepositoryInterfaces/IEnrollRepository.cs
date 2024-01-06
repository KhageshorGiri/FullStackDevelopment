using Student.Entities.Entities;

namespace Student.Application.Interfaces.RepositoryInterfaces
{
    public interface IEnrollRepository
    {
        public List<Enroll> GetAll();
        Task<Enroll> GetEnrollByIdAsync(Guid Id);
        public void AddAsync(Enroll enroll);
        public void UpdateAsync(Enroll enroll);
        public void DeleteAsync(Enroll enroll);
    }
}

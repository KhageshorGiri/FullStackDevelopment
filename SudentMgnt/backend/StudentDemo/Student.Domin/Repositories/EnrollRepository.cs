using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Entities.Entities;

namespace Student.Domin.Repositories
{
    public class EnrollRepository : IEnrollRepository
    {
        public Task AddEnrollAsync(Enroll course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEnrollAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Enroll>> GetAllEnrollListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Enroll> GetEnrollByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEnrollAsync(Guid Id, Enroll course)
        {
            throw new NotImplementedException();
        }
    }
}

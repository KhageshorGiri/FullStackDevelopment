using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Domin.DataContext;
using Student.Domin.GenericClasses;
using Student.Entities.Entities;

namespace Student.Domin.Repositories
{
    public sealed class EnrollRepository : BaseRepository<Enroll>, IEnrollRepository
    {
        public EnrollRepository(StudentDbContext dbContext) 
            : base(dbContext)
        {
        }

        public Task<Enroll> GetEnrollByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

    }
}

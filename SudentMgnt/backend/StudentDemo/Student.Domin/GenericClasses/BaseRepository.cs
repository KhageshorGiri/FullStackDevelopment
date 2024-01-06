
using Microsoft.EntityFrameworkCore;
using Student.Domin.DataContext;
using Student.Entities.Entities;

namespace Student.Domin.GenericClasses
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity newEntity);
        Task DeleteAsync(TEntity existingEntity);
        Task<List<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity existingEntity);
    }

    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {

        protected readonly StudentDbContext _dbContext;

        public BaseRepository(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public virtual async Task AddAsync(TEntity newEntity)
        {
            await _dbContext.Set<TEntity>().AddAsync(newEntity);
            _dbContext.SaveChanges();
        }

        public virtual async Task UpdateAsync(TEntity existingEntity)
        {
            _dbContext.Set<TEntity>().Update(existingEntity);
           await _dbContext.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(TEntity existingEntity)
        {
            _dbContext.Set<TEntity>().Remove(existingEntity);
            await _dbContext.SaveChangesAsync();
        }

    }
}

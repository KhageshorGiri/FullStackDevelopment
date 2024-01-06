
using Microsoft.EntityFrameworkCore;
using Student.Domin.DataContext;
using Student.Entities.Entities;

namespace Student.Domin.GenericClasses
{
    internal interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void AddAsync(TEntity newEntity);
        void DeleteAsync(TEntity existingEntity);
        List<TEntity> GetAll();
        void UpdateAsync(TEntity existingEntity);
    }

    internal abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {

        protected readonly StudentDbContext _dbContext;

        protected BaseRepository(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual List<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public virtual void AddAsync(TEntity newEntity)
        {
            _dbContext.Set<TEntity>().Add(newEntity);
            _dbContext.SaveChanges();
        }

        public virtual void UpdateAsync(TEntity existingEntity)
        {
            _dbContext.Set<TEntity>().Update(existingEntity);
            _dbContext.SaveChanges();
        }

        public virtual void DeleteAsync(TEntity existingEntity)
        {
            _dbContext.Set<TEntity>().Remove(existingEntity);
            _dbContext.SaveChanges();
        }

    }
}

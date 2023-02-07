using System.Linq.Expressions;
using DataBase.Contexts;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        private readonly Context _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(Context context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            entity.DateCreate = DateTime.Now;
            entity.DateUpdate = DateTime.Now;
            return _dbSet.Add(entity).Entity;
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public void AddRange(IEnumerable<TEntity> items)
        {
            _dbSet.AddRange(items);
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity? Get(Guid id)
        {
            return _dbSet.Where(i => i.Id == id).FirstOrDefault();
        }

        public TEntity Update(TEntity entity)
        {
            entity.DateUpdate = DateTime.Now;
            return (TEntity)_context.Update(entity).Entity;
        }

        public TEntity Attach(TEntity entity)
        {
            entity = _dbSet.Attach(entity).Entity;

            _context.Entry(entity).State = EntityState.Modified;
            ;
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            return _context.Remove(entity).Entity;
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
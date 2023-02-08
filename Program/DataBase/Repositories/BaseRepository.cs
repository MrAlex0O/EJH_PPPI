using System.Linq.Expressions;
using DataBase.Contexts;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    /// <summary>
    /// Базовый репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Тип хранимых сущностей</typeparam>
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        /// <summary>
        /// Контекст БД
        /// </summary>
        private readonly Context _context;
        /// <summary>
        /// Список хранимых сущностей
        /// </summary>
        private readonly DbSet<TEntity> _dbSet;
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="context">Контекст БД</param>
        public BaseRepository(Context context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        /// <summary>
        /// Добавить модель
        /// </summary>
        /// <param name="entity">Модель</param>
        /// <returns>Добавленная модель с трекингом</returns>
        public TEntity Add(TEntity entity)
        {
            entity.DateCreate = DateTime.Now;
            entity.DateUpdate = DateTime.Now;
            return _dbSet.Add(entity).Entity;
        }
        /// <summary>
        /// Найти модели по условию
        /// </summary>
        /// <param name="expression">Условие поиска (выражение)</param>
        /// <returns>Список найденных моделей</returns>
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
        /// <summary>
        /// Добавить список моделей
        /// </summary>
        /// <param name="items">Список моделей для добавления</param>
        public void AddRange(IEnumerable<TEntity> items)
        {
            _dbSet.AddRange(items);
        }
        /// <summary>
        /// Получить все модели
        /// </summary>
        /// <returns>Список всех моделей</returns>
        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
        /// <summary>
        /// Получить модель по id
        /// </summary>
        /// <param name="id">id модели</param>
        /// <returns>Модель по id</returns>
        public TEntity? Get(Guid id)
        {
            return _dbSet.Where(i => i.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Обновить модель с трекингом
        /// </summary>
        /// <param name="entity">Модель для обновления</param>
        /// <returns>Обновленная модель с трекингом</returns>
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
        /// <summary>
        /// Удалить модель
        /// </summary>
        /// <param name="entity">Модель для удаления</param>
        /// <returns>Удаленная модель</returns>
        public TEntity Delete(TEntity entity)
        {
            return _context.Remove(entity).Entity;
        }
        /// <summary>
        /// Асинхронное сохранение изменений
        /// </summary>
        /// <returns>Результат сохранения</returns>
        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
        /// <summary>
        /// Сохранить изменения
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Contexts
{
    /// <summary>
    /// Контекст БД
    /// </summary>
    public class Context : DbContext, IWebContext
    {
        /// <summary>
        /// Строка подключения к БД
        /// </summary>
        string _connectionString;
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="configuration">Файл конфигураций</param>
        public Context(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];

        }
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="options">Параметры контекста</param>
        /// <param name="configuration">Файл конфигураций</param>
        public Context(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<LessonVisitor> LessonsVisitors { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonType> LessonTypes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<StatusOnLesson> StatusOnLessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        /// <summary>
        /// Событие "при конфигурации"
        /// </summary>
        /// <param name="optionsBuilder">Параметры конфигурации</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
        /// <summary>
        /// Событие "при создании моделей"
        /// </summary>
        /// <param name="modelBuilder">Генератор моделей</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedDB.UpdateTables(modelBuilder);

            modelBuilder.Entity<LessonVisitor>()
                .HasOne<Lesson>(v => v.Lesson)
                .WithMany(l => l.LessonVisitors)
                .HasForeignKey(x => x.LessonId);

            modelBuilder.Entity<Lesson>()
                .HasOne<Discipline>(x => x.Discipline)
                .WithMany(i => i.Lessons)
                .HasForeignKey(x => x.DisciplineId);

            modelBuilder.Entity<Student>()
                .HasOne<Group>(s => s.Group)
                .WithMany(i => i.Studnets)
                .HasForeignKey(x => x.GroupId);

            modelBuilder.Entity<Discipline>()
                .HasOne<Group>(d => d.Group)
                .WithMany(i => i.Disciplines)
                .HasForeignKey(x => x.GroupId);
        }
        /// <summary>
        /// Асинхронное сохранение изменений
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Результат сохранения</returns>
        public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await base.SaveChangesAsync(cancellationToken);
            }
            catch (Exception)
            {
                //handle with some logger
                return false;
            }

            return true;
        }
        /// <summary>
        /// Сохранить изменения
        /// </summary>
        /// <returns>Успешность сохранения</returns>
        public bool SaveChanges()
        {
            try
            {
                base.SaveChanges();
            }
            catch (Exception e)
            {
                //handle with some logger
                Console.WriteLine(e);
                return false;
            }

            return true;
        }
        /// <summary>
        /// Обновить модель
        /// </summary>
        /// <typeparam name="TEntity">Тип модели</typeparam>
        /// <param name="entity">Модель для обновления</param>
        /// <returns>Обновленная модель</returns>
        public EntityEntry? Update<TEntity>(TEntity entity)
        {
            try
            {
                return base.Update(entity);
            }
            catch (Exception e)
            {
                //handle with some logger
                Console.WriteLine(e);
                return null;
            }

        }
        /// <summary>
        /// "Деструктор" класса
        /// </summary>
        /// <returns>Успешность уничтожения</returns>
        public bool Dispose()
        {
            try
            {
                base.Dispose();
            }
            catch (Exception e)
            {
                //handle with some logger
                Console.WriteLine(e);
                return false;
            }

            return true;
        }
    }
}

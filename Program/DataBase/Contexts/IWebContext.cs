using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Contexts
{
    public interface IWebContext
    {
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
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
        public Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
        public bool SaveChanges();
        public EntityEntry Update<TEntity>(TEntity entity);
        public bool Dispose();
    }
}

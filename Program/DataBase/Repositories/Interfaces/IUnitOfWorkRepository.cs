using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories.Interfaces
{
    public interface IUnitOfWorkRepository
    {
        public BaseRepository<Assistant> Assistants { get; }
        public BaseRepository<Discipline> Disciplines { get; }
        public BaseRepository<Group> Groups { get; }
        public BaseRepository<LessonVisitor> LessonVisitors { get; }
        public BaseRepository<Lesson> Lessons { get; }
        public BaseRepository<LessonType> LessonTypes { get; }
        public BaseRepository<Person> Persons { get; }
        public BaseRepository<StatusOnLesson> StatusesOnLesson { get; }
        public BaseRepository<Student> Students { get; }
        public BaseRepository<Teacher> Teachers { get; }
        public BaseRepository<User> Users { get; }
        public BaseRepository<Role> Roles { get; }
        public BaseRepository<UserRole> UserRoles { get; }
        public void SaveChanges();

        public Task SaveChangesAsync();

        public void Dispose(bool disposing);

        public void Dispose();
    }
}

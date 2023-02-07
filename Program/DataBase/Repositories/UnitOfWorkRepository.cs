using DataBase.Contexts;
using DataBase;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public sealed class UnitOfWorkRepository : IUnitOfWorkRepository, IDisposable
    {
        public UnitOfWorkRepository(IWebContext context)
        {
            _context = context;
        }
        private readonly IWebContext _context;
        private BaseRepository<Assistant>? _assistantsRepository;
        private BaseRepository<Discipline>? _disciplinesRepository;
        private BaseRepository<Group>? _groupRepository;
        private BaseRepository<LessonVisitor>? _lessonVisitorsRepository;
        private BaseRepository<Lesson>? _lessonRepository;
        private BaseRepository<LessonType>? _lessonTypeRepository;
        private BaseRepository<Person>? _personRepository;
        private BaseRepository<StatusOnLesson>? _statusOnLessonRepository;
        private BaseRepository<Student>? _studentRepository;
        private BaseRepository<Teacher>? _teacherRepository;

        private BaseRepository<User>? _userRepository;
        private BaseRepository<Role>? _roleRepository;
        private BaseRepository<UserRole>? _userRoleRepository;

        private bool _disposed = false;

        public BaseRepository<Assistant> Assistants => _assistantsRepository ??= new BaseRepository<Assistant>((Context)_context);
        public BaseRepository<Discipline> Disciplines => _disciplinesRepository ??= new BaseRepository<Discipline>((Context)_context);
        public BaseRepository<Group> Groups => _groupRepository ??= new BaseRepository<Group>((Context)_context);
        public BaseRepository<LessonVisitor> LessonVisitors => _lessonVisitorsRepository ??= new BaseRepository<LessonVisitor>((Context)_context);
        public BaseRepository<Lesson> Lessons => _lessonRepository ??= new BaseRepository<Lesson>((Context)_context);
        public BaseRepository<LessonType> LessonTypes => _lessonTypeRepository ??= new BaseRepository<LessonType>((Context)_context);
        public BaseRepository<Person> Persons => _personRepository ??= new BaseRepository<Person>((Context)_context);
        public BaseRepository<StatusOnLesson> StatusesOnLesson => _statusOnLessonRepository ??= new BaseRepository<StatusOnLesson>((Context)_context);
        public BaseRepository<Student> Students => _studentRepository ??= new BaseRepository<Student>((Context)_context);
        public BaseRepository<Teacher> Teachers => _teacherRepository ??= new BaseRepository<Teacher>((Context)_context);
        public BaseRepository<User> Users => _userRepository ??= new BaseRepository<User>((Context)_context);
        public BaseRepository<Role> Roles => _roleRepository ??= new BaseRepository<Role>((Context)_context);
        public BaseRepository<UserRole> UserRoles => _userRoleRepository ??= new BaseRepository<UserRole>((Context)_context);
        

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

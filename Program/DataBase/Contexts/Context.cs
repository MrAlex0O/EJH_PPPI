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
    public class Context : DbContext, IWebContext
    {
        string _connectionString;
        public Context(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];

        }
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
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

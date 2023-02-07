using AutoMapper;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Logic.DTOs.Student;
using Logic.WriteServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices
{
    public class StudentWriteService : IStudentWriteService
    {
        private IUnitOfWorkRepository _repositories;
        readonly IMapper _mapper;
        public StudentWriteService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }
        public void Add(Guid personId, Guid groupId)
        {
            Student student = new Student { PersonId = personId, GroupId = groupId };
            _repositories.Students.Add(student);
            _repositories.SaveChanges();
        }
        public Student Update(Guid id, UpdateStudentRequest updateStudentRequest)
        {
            Student student = _repositories.Students.Get(id);
            _mapper.Map<UpdateStudentRequest, Student>(updateStudentRequest, student);
            _repositories.Students.Update(student);
            _repositories.SaveChanges();
            return student;
        }
        public Student Delete(Guid id)
        {
            Student student = _repositories.Students.Get(id);
            _repositories.Students.Delete(student);
            _repositories.SaveChanges();
            return student;
        }
    }
}

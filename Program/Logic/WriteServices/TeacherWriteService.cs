using AutoMapper;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Logic.DTOs.Teacher;
using Logic.WriteServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices
{
    public class TeacherWriteService : ITeacherWriteService
    {
        private IUnitOfWorkRepository _repositories;
        readonly IMapper _mapper;
        public TeacherWriteService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }
        public void Add(Guid personId)
        {
            Teacher teacher = new Teacher { PersonId = personId};
            _repositories.Teachers.Add(teacher);
            _repositories.SaveChanges();
        }
        public Teacher Update(Guid id, UpdateTeacherRequest updateTeacherRequest)
        {
            Teacher teacher = _repositories.Teachers.Get(id);
            Person person = _repositories.Persons.Get((Guid)teacher.PersonId);
            _mapper.Map<UpdateTeacherRequest, Teacher>(updateTeacherRequest, teacher);
            _mapper.Map<UpdateTeacherRequest, Person>(updateTeacherRequest, person);
            teacher.Person = person;
            _repositories.Teachers.Update(teacher);
            _repositories.SaveChanges();
            return teacher;

        }
        public Teacher Delete(Guid id)
        {
            Teacher teacher = _repositories.Teachers.Get(id);
            _repositories.Teachers.Delete(teacher);
            _repositories.SaveChanges();
            return teacher;
        }
    }
}

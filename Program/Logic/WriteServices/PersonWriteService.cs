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
    public class PersonWriteService : IPersonWriteService
    {
        private IUnitOfWorkRepository _repositories;
        readonly IMapper _mapper;
        public PersonWriteService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        public Guid Add(Person person)
        {
            Guid id = _repositories.Persons.Add(person).Id;
            _repositories.SaveChanges();
            return id;
        }

        public void Update(Guid id, Person updatePerson)
        {
            Person person = _repositories.Persons.Get(id);
            _mapper.Map<Person, Person>(updatePerson, person);
            _repositories.Persons.Update(person);
            _repositories.SaveChanges();
        }
        public void Delete(Guid id)
        {
            Person person = _repositories.Persons.Get(id);
            _repositories.Persons.Delete(person);
            _repositories.SaveChanges();
        }

    }
}

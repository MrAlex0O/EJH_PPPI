using AutoMapper;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Logic.DTOs.Discipline;
using Logic.WriteServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices
{
    public class DisciplineWriteService : IDisciplineWriteService
    {
        private IUnitOfWorkRepository _repositories;
        readonly IMapper _mapper;
        public DisciplineWriteService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        public Guid Add(CreateDisciplineRequest createDisciplineRequest)
        {
            Guid id = _repositories.Disciplines.Add(_mapper.Map<Discipline>(createDisciplineRequest)).Id;
            _repositories.SaveChanges();
            return id;
        }

        public void Update(Guid id, UpdateDisciplineRequest updateDisciplineRequest)
        {
            Discipline discipline = _repositories.Disciplines.Get(id);
            _mapper.Map<UpdateDisciplineRequest, Discipline>(updateDisciplineRequest, discipline);
            _repositories.Disciplines.Update(discipline);
            _repositories.SaveChanges();
        }
        public void Delete(Guid id)
        {
            Discipline discipline = _repositories.Disciplines.Get(id);
            _repositories.Disciplines.Delete(discipline);
            _repositories.SaveChanges();
        }
    }
}

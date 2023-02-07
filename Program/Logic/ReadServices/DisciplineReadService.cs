using Logic.DTOs.Discipline;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    public class DisciplineReadService : IDisciplineReadService
    {
        IDisciplineQuery _disciplineQuery;
        public DisciplineReadService(IDisciplineQuery disciplineQuery)
        {
            _disciplineQuery = disciplineQuery;
        }
        public List<GetDisciplineResponse> GetAll()
        {
            return _disciplineQuery.GetAll();
        }
        public GetDisciplineResponse Get(Guid id)
        {
            return _disciplineQuery.Get(id);
        }
        public List<GetDisciplineResponse> GetByTeacherId(Guid teacherId)
        {
            return _disciplineQuery.GetByTeacherId(teacherId);
        }
    }
}

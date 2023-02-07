using Logic.DTOs.Discipline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Queries.Interfaces
{
    public interface IDisciplineQuery
    {
        public List<GetDisciplineResponse> GetAll();
        public GetDisciplineResponse Get(Guid id);
        public List<GetDisciplineResponse> GetByTeacherId(Guid teacherId);
    }
}

using Logic.DTOs.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Queries.Interfaces
{
    public interface ITeacherQuery
    {
        public List<GetTeacherResponse> GetAll();
        public GetTeacherResponse Get(Guid id);
    }
}

using Logic.DTOs.Teacher;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    public class TeacherReadService : ITeacherReadService
    {
        ITeacherQuery _teacherQuery;
        public TeacherReadService(ITeacherQuery teacherQuery)
        {
            _teacherQuery = teacherQuery;
        }
        public GetTeacherResponse Get(Guid id)
        {
            return _teacherQuery.Get(id);
        }

        public List<GetTeacherResponse> GetAll()
        {
            return _teacherQuery.GetAll();
        }
    }
}

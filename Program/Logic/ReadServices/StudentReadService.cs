using Logic.DTOs.Student;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    public class StudentReadService : IStudentReadService
    {
        IStudentQuery _studentQuery;
        public StudentReadService(IStudentQuery studentQuery)
        {
            _studentQuery = studentQuery;
        }
        public GetStudentResponse Get(Guid id)
        {
            return _studentQuery.Get(id);
        }

        public List<GetStudentResponse> GetAll()
        {
            return _studentQuery.GetAll();
        }

        public List<GetStudentResponse> GetByGroupId(Guid groupId)
        {
            return _studentQuery.GetByGroupId(groupId);
        }
    }
}

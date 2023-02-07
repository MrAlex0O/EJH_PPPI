using Logic.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices.Interfaces
{
    public interface IStudentReadService
    {
        public List<GetStudentResponse> GetAll();
        public GetStudentResponse Get(Guid id);
        public List<GetStudentResponse> GetByGroupId(Guid groupIdd);
    }
}

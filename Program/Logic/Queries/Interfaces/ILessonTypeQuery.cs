using Logic.DTOs.LessonType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Queries.Interfaces
{
    public interface ILessonTypeQuery
    {
        public List<GetLessonTypeResponse> GetAll();
        public GetLessonTypeResponse Get(Guid id);
    }
}

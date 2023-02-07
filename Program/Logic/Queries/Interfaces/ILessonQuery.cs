using Logic.DTOs.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Queries.Interfaces
{
    public interface ILessonQuery
    {
        public List<GetLessonResponse> GetAll();
        public GetLessonResponse Get(Guid id);
    }
}

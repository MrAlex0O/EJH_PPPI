using Logic.DTOs.LessonVisitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Queries.Interfaces
{
    public interface ILessonVisitorQuery
    {
        public List<GetLessonVisitorResponse> GetAll();
        public GetLessonVisitorResponse GetByLessonId(Guid id);
    }
}

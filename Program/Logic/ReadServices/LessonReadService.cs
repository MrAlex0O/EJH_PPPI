using Logic.DTOs.Lesson;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    public class LessonReadService : ILessonReadService
    {
        ILessonQuery _lessonQuery;
        public LessonReadService(ILessonQuery lessonQuery)
        {
            _lessonQuery = lessonQuery;
        }
        public List<GetLessonResponse> GetAll()
        {
            return _lessonQuery.GetAll();
        }
        public GetLessonResponse Get(Guid id)
        {
            return _lessonQuery.Get(id);
        }
    }
}

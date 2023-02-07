using Logic.DTOs.LessonType;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    public class LessonTypeReadService : ILessonTypeReadService
    {
        ILessonTypeQuery _lessonTypeQuery;
        public LessonTypeReadService(ILessonTypeQuery query)
        {
            _lessonTypeQuery = query;
        }
        public List<GetLessonTypeResponse> GetAll()
        {
            return _lessonTypeQuery.GetAll();
        }
        public GetLessonTypeResponse Get(Guid id)
        {
            return _lessonTypeQuery.Get(id);
        }
    }
}

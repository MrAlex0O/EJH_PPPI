using Logic.DTOs.LessonVisitors;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    public class LessonVisitorReadService : ILessonVisitorReadService
    {
        ILessonVisitorQuery _groupQuery;
        public LessonVisitorReadService(ILessonVisitorQuery query)
        {
            _groupQuery = query;
        }
        public List<GetLessonVisitorResponse> GetAll()
        {
            return _groupQuery.GetAll();
        }
        public GetLessonVisitorResponse GetByLessonId(Guid id)
        {
            return _groupQuery.GetByLessonId(id);
        }
    }
}

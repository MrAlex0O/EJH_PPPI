using Logic.DTOs.StatusOnLesson;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    public class StatusOnLessonReadService : IStatusOnLessonReadService
    {
        IStatusOnLessonQuery _statusOnLessonQuery;
        public StatusOnLessonReadService(IStatusOnLessonQuery query)
        {
            _statusOnLessonQuery = query;
        }
        public GetStatusOnLessonResponse Get(Guid id)
        {
            return _statusOnLessonQuery.Get(id);
        }

        public List<GetStatusOnLessonResponse> GetAll()
        {
            return _statusOnLessonQuery.GetAll();
        }
    }
}

using Logic.DTOs.StatusOnLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Queries.Interfaces
{
    public interface IStatusOnLessonQuery
    {
        public List<GetStatusOnLessonResponse> GetAll();
        public GetStatusOnLessonResponse Get(Guid id);
    }
}

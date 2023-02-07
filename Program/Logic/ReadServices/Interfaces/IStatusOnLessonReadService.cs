using Logic.DTOs.StatusOnLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices.Interfaces
{
    public interface IStatusOnLessonReadService
    {
        public List<GetStatusOnLessonResponse> GetAll();
        public GetStatusOnLessonResponse Get(Guid id);
    }
}

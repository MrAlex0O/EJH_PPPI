using Logic.DTOs.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices.Interfaces
{
    public interface ILessonReadService
    {
        public List<GetLessonResponse> GetAll();
        public GetLessonResponse Get(Guid id);
    }
}

using Logic.DTOs.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices.Interfaces
{
    public interface ILessonWriteService
    {
        public Guid Add(CreateLessonRequest createLessonRequest);
        public void Update(Guid id, UpdateLessonRequest updateLessonRequest);
        public void Delete(Guid id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.LessonVisitors
{
    public class GetLessonVisitorResponse
    {
        public Guid DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public DateTime Date { get; set; }
        public Guid LessonId { get; set; }
        public Guid LessonTypeId { get; set; }
        public string LessonTypeName { get; set; }      
        public Guid[] StudentsIds { get; set; }
        public Guid[] LessonsVisitorsIds { get; set; }
        public string[] StudentFullName { get; set; }
        public Guid[] StudentStatusesIds { get; set; }
        public string[] StudentStatusesNames { get; set; }
    }
}

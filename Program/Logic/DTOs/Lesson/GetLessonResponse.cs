using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.Lesson
{
    public class GetLessonResponse
    {
        public Guid Id { get; set; }
        public Guid DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public Guid LectorId { get; set; }
        public string LectorFullName { get; set; }
        public Guid[] AssistantsIds { get; set; }
        public string[] AssistantsFullNames { get; set; }
        public Guid LessonTypeId { get; set; }
        public string LessonType { get; set; }
        public DateTime Date { get; set; }
        public int SequenceNumber { get; set; }
    }
}

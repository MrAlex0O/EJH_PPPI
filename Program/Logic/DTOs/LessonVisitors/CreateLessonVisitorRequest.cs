using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.LessonVisitors
{
    public class CreateLessonVisitorRequest
    {
        public Guid LessonId { get; set; }
        public Guid StudentId { get; set; }
        public Guid StatusOnLessonId { get; set; }
    }
}

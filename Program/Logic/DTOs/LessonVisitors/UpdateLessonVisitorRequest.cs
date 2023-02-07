using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.LessonVisitors
{
    public class UpdateLessonVisitorRequest
    {
        public Guid LessonId { get; set; }
        public Guid StudentId { get; set; }
        public Guid StatusId { get; set; }
    }
}

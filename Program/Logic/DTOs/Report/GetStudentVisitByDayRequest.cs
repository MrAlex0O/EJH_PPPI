using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.Report
{
    public class GetStudentVisitByDayRequest
    {
        public Guid StudentId { get; set; }
        public DateTime Date { get; set; }
    }
}

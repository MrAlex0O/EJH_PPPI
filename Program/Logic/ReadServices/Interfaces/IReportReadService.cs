using Logic.DTOs.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices.Interfaces
{
    public interface IReportReadService
    {
        public List<GetDisciplineVisitsReportResponse> GetDisciplineVisits(Guid disciplineId);
        public List<GetStudentVisitsResponse> GetDisciplineVisitsByStudentId(Guid studentId);
        public List<GetStudentVisitsResponse> GetStudentVisitsByDay(GetStudentVisitByDayRequest request);
        public List<GetStudentVisitsResponse> GetStudentVisitsByInterval(GetStudentVisitsByIntervalRequest request);

    }
}

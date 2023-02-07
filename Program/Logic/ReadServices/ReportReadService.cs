using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Enums;
using DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Logic.Queries.Interfaces;
using Logic.DTOs.Report;

namespace Logic.ReadServices
{
    public class ReportReadService : IReportReadService
    {
        private IReportQuery _reportQuery;

        public ReportReadService(IReportQuery reportQuery)
        {
            _reportQuery = reportQuery;
        }

        public List<GetDisciplineVisitsReportResponse> GetDisciplineVisits(Guid disciplineId)
        {
            return _reportQuery.GetDisciplineVisits(disciplineId);
        }
        public List<GetStudentVisitsResponse> GetDisciplineVisitsByStudentId(Guid studentId)
        {
            return _reportQuery.GetDisciplineVisitsByStudentId(studentId);
        }

        public List<GetStudentVisitsResponse> GetStudentVisitsByDay(GetStudentVisitByDayRequest request)
        {
            return _reportQuery.GetStudentVisitsByDay(request);
        }

        public List<GetStudentVisitsResponse> GetStudentVisitsByInterval(GetStudentVisitsByIntervalRequest request)
        {
            return _reportQuery.GetStudentVisitsByInterval(request);
        }
    }
}
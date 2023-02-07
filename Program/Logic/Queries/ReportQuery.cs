using Dapper;
using Logic.DTOs.Report;
using Logic.Queries.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Logic.Queries
{
    public class ReportQuery : IReportQuery
    {
        string _connectionString;
        public ReportQuery(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public List<GetDisciplineVisitsReportResponse> GetDisciplineVisits(Guid disciplineId)
        {
            string querry = $@"SELECT DISTINCT ""Persons"".""Surname"" || ' ' || ""Persons"".""Name"" || ' ' || ""Persons"".""Midname"" AS ""FullName""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 1)) OVER(PARTITION BY ""Persons"".""Surname"") AS ""Present""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 2)) OVER(PARTITION BY ""Persons"".""Surname"") AS ""Missing""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 3)) OVER(PARTITION BY ""Persons"".""Surname"") AS ""Liberation""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 4)) OVER(PARTITION BY ""Persons"".""Surname"") AS ""AnotherSubgroup""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 5)) OVER(PARTITION BY ""Persons"".""Surname"") AS ""SeriousReason""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 6)) OVER(PARTITION BY ""Persons"".""Surname"") AS ""Incalculable""

FROM ""LessonsVisitors""
INNER JOIN ""Students"" ON ""Students"".""Id"" = ""LessonsVisitors"".""StudentId""
INNER JOIN ""Persons"" ON ""Persons"".""Id"" = ""Students"".""PersonId""
INNER JOIN ""Lessons"" ON ""Lessons"".""Id"" = ""LessonsVisitors"".""LessonId""
INNER JOIN ""StatusOnLessons"" ON ""StatusOnLessons"".""Id"" = ""LessonsVisitors"".""StatusOnLessonId""
WHERE ""Lessons"".""DisciplineId"" = '{disciplineId}'
GROUP BY ""Persons"".""Surname"", ""Persons"".""Name"", ""Persons"".""Midname"", ""StatusOnLessons"".""Name""
ORDER BY 1";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetDisciplineVisitsReportResponse>(querry).ToList();
            }
        }
        public List<GetStudentVisitsResponse> GetDisciplineVisitsByStudentId(Guid studentId)
        {
            string querry = $@"SELECT DISTINCT ""Disciplines"".""Name"" AS ""Disciplinename"", ""LessonTypes"".""Name"" AS ""LessonTypeName"" 
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 1)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Present""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 2)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Missing""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 3)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Liberation""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 4)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""AnotherSubgroup""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 5)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""SeriousReason""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 6)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Incalculable""
FROM ""LessonsVisitors""
INNER JOIN ""Students"" ON ""Students"".""Id"" = ""LessonsVisitors"".""StudentId""
INNER JOIN ""Persons"" ON ""Persons"".""Id"" = ""Students"".""PersonId""
INNER JOIN ""Lessons"" ON ""Lessons"".""Id"" = ""LessonsVisitors"".""LessonId""
INNER JOIN ""Disciplines"" ON ""Disciplines"".""Id"" = ""Lessons"".""DisciplineId""
INNER JOIN ""LessonTypes"" ON ""Lessons"".""LessonTypeId"" = ""LessonTypes"".""Id""
INNER JOIN ""StatusOnLessons"" ON ""StatusOnLessons"".""Id"" = ""LessonsVisitors"".""StatusOnLessonId""
WHERE ""Students"".""Id"" = '{studentId}'
GROUP BY ""Disciplines"".""Name"", ""StatusOnLessons"".""Name"", ""LessonTypes"".""Name""
ORDER BY 1, 2";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetStudentVisitsResponse>(querry).ToList();
            }
        }
        
        public List<GetStudentVisitsResponse> GetStudentVisitsByDay(GetStudentVisitByDayRequest request)
        {
            string querry = $@"SELECT DISTINCT ""Disciplines"".""Name"" AS ""Disciplinename"", ""LessonTypes"".""Name"" AS ""LessonTypeName"" 
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 1)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Present""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 2)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Missing""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 3)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Liberation""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 4)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""AnotherSubgroup""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 5)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""SeriousReason""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 6)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Incalculable""
FROM ""LessonsVisitors""
INNER JOIN ""Students"" ON ""Students"".""Id"" = ""LessonsVisitors"".""StudentId""
INNER JOIN ""Persons"" ON ""Persons"".""Id"" = ""Students"".""PersonId""
INNER JOIN ""Lessons"" ON ""Lessons"".""Id"" = ""LessonsVisitors"".""LessonId""
INNER JOIN ""Disciplines"" ON ""Disciplines"".""Id"" = ""Lessons"".""DisciplineId""
INNER JOIN ""LessonTypes"" ON ""Lessons"".""LessonTypeId"" = ""LessonTypes"".""Id""
INNER JOIN ""StatusOnLessons"" ON ""StatusOnLessons"".""Id"" = ""LessonsVisitors"".""StatusOnLessonId""
WHERE ""Students"".""Id"" = '{request.StudentId}'
AND ""Lessons"".""Date"" = '{request.Date}'
GROUP BY ""Disciplines"".""Name"", ""StatusOnLessons"".""Name"", ""LessonTypes"".""Name""
ORDER BY 1, 2";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetStudentVisitsResponse>(querry).ToList();
            }
        }
        public List<GetStudentVisitsResponse> GetStudentVisitsByInterval(GetStudentVisitsByIntervalRequest request)
        {
            string querry = $@"SELECT DISTINCT ""Disciplines"".""Name"" AS ""Disciplinename"", ""LessonTypes"".""Name"" AS ""LessonTypeName"" 
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 1)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Present""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 2)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Missing""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 3)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Liberation""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 4)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""AnotherSubgroup""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 5)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""SeriousReason""
, sum(count(""StatusOnLessons"".""Id"") FILTER(WHERE ""StatusOnLessons"".""EnumId"" = 6)) OVER(PARTITION BY ""LessonTypes"".""Name"", ""Disciplines"".""Name"") AS ""Incalculable""
FROM ""LessonsVisitors""
INNER JOIN ""Students"" ON ""Students"".""Id"" = ""LessonsVisitors"".""StudentId""
INNER JOIN ""Persons"" ON ""Persons"".""Id"" = ""Students"".""PersonId""
INNER JOIN ""Lessons"" ON ""Lessons"".""Id"" = ""LessonsVisitors"".""LessonId""
INNER JOIN ""Disciplines"" ON ""Disciplines"".""Id"" = ""Lessons"".""DisciplineId""
INNER JOIN ""LessonTypes"" ON ""Lessons"".""LessonTypeId"" = ""LessonTypes"".""Id""
INNER JOIN ""StatusOnLessons"" ON ""StatusOnLessons"".""Id"" = ""LessonsVisitors"".""StatusOnLessonId""
WHERE ""Students"".""Id"" = '{request.StudentId}'
AND ""Lessons"".""Date"" >= '{request.DateStart}'
AND ""Lessons"".""Date"" <= '{request.DateEnd}'
GROUP BY ""Disciplines"".""Name"", ""StatusOnLessons"".""Name"", ""LessonTypes"".""Name""
ORDER BY 1, 2";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetStudentVisitsResponse>(querry).ToList();
            }
        }
    }
}


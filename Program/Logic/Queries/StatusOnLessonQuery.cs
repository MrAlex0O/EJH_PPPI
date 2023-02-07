using Dapper;
using Logic.DTOs.StatusOnLesson;
using Logic.Queries.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Queries
{
    public class StatusOnLessonQuery : IStatusOnLessonQuery
    {
        string _connectionString;
        public StatusOnLessonQuery(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public List<GetStatusOnLessonResponse> GetAll()
        {
            string querry = $@"SELECT ""Id"", ""Name"" FROM ""StatusOnLessons""
                                ORDER BY ""DateCreate"" ASC";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetStatusOnLessonResponse>(querry).ToList();
            }
        }
        public GetStatusOnLessonResponse Get(Guid id)
        {
            string querry = $@"SELECT ""Id"", ""Name"" FROM ""StatusOnLessons""
                                WHERE ""Id"" = '{id}'";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetStatusOnLessonResponse>(querry).FirstOrDefault();
            }
        }
    }
}

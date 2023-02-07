using Dapper;
using Logic.DTOs.LessonType;
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
    public class LessonTypeQuery : ILessonTypeQuery
    {
        string _connectionString;
        public LessonTypeQuery(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public List<GetLessonTypeResponse> GetAll()
        {
            string querry = $@"SELECT ""Id"", ""Name"" FROM ""LessonTypes""
                                ORDER BY ""DateCreate"" ASC";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetLessonTypeResponse>(querry).ToList();
            }
        }
        public GetLessonTypeResponse Get(Guid id)
        {
            string querry = $@"SELECT ""Id"", ""Name"" FROM ""LessonTypes""
                                WHERE ""Id"" = '{id}'";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetLessonTypeResponse>(querry).FirstOrDefault();
            }
        }
    }
}

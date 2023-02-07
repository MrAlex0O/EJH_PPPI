using Dapper;
using Logic.DTOs.Discipline;
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
    public class DisciplineQuery : IDisciplineQuery
    {
        string _connectionString;
        public DisciplineQuery(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public List<GetDisciplineResponse> GetAll()
        {
            string querry = $@"SELECT ""Disciplines"".""Id"", ""Disciplines"".""Name"",

                            l.""Id"" AS ""LectorId"", l1.""Surname"" || ' ' || l1.""Name"" || ' ' || l1.""Midname"" AS ""LectorFullName"",
		                    ""Groups"".""Id"" AS ""GroupId"", ""Groups"".""Name"" AS ""GroupName"",
		                    ""Disciplines"".""Semester"",
		                    array_remove(array_agg(a.""Id""), null) AS ""AssistantsIds"",

                            array_remove(array_agg(a1.""Surname"" || ' ' || a1.""Name"" || ' ' || a1.""Midname""), null) AS ""AssistantsFullNames""
                            FROM ""Disciplines""
                            LEFT JOIN ""Groups"" ON ""Groups"".""Id"" = ""Disciplines"".""GroupId""
                            LEFT JOIN ""Teachers"" AS l ON l.""Id"" = ""Disciplines"".""LectorId""
                            LEFT JOIN ""Persons"" AS l1 ON l1.""Id"" = l.""PersonId""
                            LEFT JOIN ""Assistants"" AS a0 ON a0.""DisciplineId"" = ""Disciplines"".""Id""
                            LEFT JOIN ""Teachers"" AS a ON a.""Id"" = a0.""TeacherId""
                            LEFT JOIN ""Persons"" AS a1 ON a1.""Id"" = a.""PersonId""
                            GROUP BY ""Disciplines"".""Id"", 
		                    l.""Id"", l1.""Surname"" || ' ' || l1.""Name"" || ' ' || l1.""Midname"",
		                    ""Groups"".""Id"", ""Groups"".""Name"",
		                    ""Disciplines"".""Semester""
                            ORDER BY ""Disciplines"".""DateCreate"" ASC";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetDisciplineResponse>(querry).ToList();
            }
        }
        public GetDisciplineResponse Get(Guid id)
        {
            string querry = $@"SELECT ""Disciplines"".""Id"", ""Disciplines"".""Name"",

                            l.""Id"" AS ""LectorId"", l1.""Surname"" || ' ' || l1.""Name"" || ' ' || l1.""Midname"" AS ""LectorFullName"",
		                    ""Groups"".""Id"" AS ""GroupId"", ""Groups"".""Name"" AS ""GroupName"",
		                    ""Disciplines"".""Semester"",
		                    array_remove(array_agg(a.""Id""), null) AS ""AssistantsIds"",

                            array_remove(array_agg(a1.""Surname"" || ' ' || a1.""Name"" || ' ' || a1.""Midname""), null) AS ""AssistantsFullNames""
                            FROM ""Disciplines""
                            LEFT JOIN ""Groups"" ON ""Groups"".""Id"" = ""Disciplines"".""GroupId""
                            LEFT JOIN ""Teachers"" AS l ON l.""Id"" = ""Disciplines"".""LectorId""
                            LEFT JOIN ""Persons"" AS l1 ON l1.""Id"" = l.""PersonId""
                            LEFT JOIN ""Assistants"" AS a0 ON a0.""DisciplineId"" = ""Disciplines"".""Id""
                            LEFT JOIN ""Teachers"" AS a ON a.""Id"" = a0.""TeacherId""
                            LEFT JOIN ""Persons"" AS a1 ON a1.""Id"" = a.""PersonId""
                            WHERE ""Disciplines"".""Id""='{id}'
                            GROUP BY ""Disciplines"".""Id"", 
		                    l.""Id"", l1.""Surname"" || ' ' || l1.""Name"" || ' ' || l1.""Midname"",
		                    ""Groups"".""Id"", ""Groups"".""Name"",
		                    ""Disciplines"".""Semester""";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetDisciplineResponse>(querry).FirstOrDefault();
            }
        }
        public List<GetDisciplineResponse> GetByTeacherId(Guid teacherId)
        {
            string querry = $@"SELECT * FROM (

SELECT ""Disciplines"".""Id"", ""Disciplines"".""Name"",

        l.""Id"" AS ""LectorId"", l1.""Surname"" || ' ' || l1.""Name"" || ' ' || l1.""Midname"" AS ""LectorFullName"",
		""Groups"".""Id"" AS ""GroupId"", ""Groups"".""Name"" AS ""GroupName"",
		""Disciplines"".""Semester"",
		array_remove(array_agg(a.""Id""), null) AS ""AssistantsIds"",

        array_remove(array_agg(a1.""Surname"" || ' ' || a1.""Name"" || ' ' || a1.""Midname""), null) AS ""AssistantsFullNames""
FROM ""Disciplines""
LEFT JOIN ""Groups"" ON ""Groups"".""Id"" = ""Disciplines"".""GroupId""
LEFT JOIN ""Teachers"" AS l ON l.""Id"" = ""Disciplines"".""LectorId""
LEFT JOIN ""Persons"" AS l1 ON l1.""Id"" = l.""PersonId""
LEFT JOIN ""Assistants"" AS a0 ON a0.""DisciplineId"" = ""Disciplines"".""Id""
LEFT JOIN ""Teachers"" AS a ON a.""Id"" = a0.""TeacherId""
LEFT JOIN ""Persons"" AS a1 ON a1.""Id"" = a.""PersonId""

GROUP BY ""Disciplines"".""Id"", 
		l.""Id"", l1.""Surname"" || ' ' || l1.""Name"" || ' ' || l1.""Midname"",
		""Groups"".""Id"", ""Groups"".""Name"",
		""Disciplines"".""Semester""
ORDER BY ""Disciplines"".""DateCreate"" ASC) AS a

WHERE ""LectorId"" = '{teacherId}'
OR '{teacherId}' = ANY (""AssistantsIds"")";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetDisciplineResponse>(querry).ToList();
            }
        }
    }
}

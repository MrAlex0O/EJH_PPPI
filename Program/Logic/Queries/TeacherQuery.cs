using Dapper;
using Logic.DTOs.Teacher;
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
    public class TeacherQuery : ITeacherQuery
    {
        string _connectionString;
        public TeacherQuery(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public List<GetTeacherResponse> GetAll()
        {
            string querry = $@"SELECT ""Teachers"".""Id"", 
                            ""Persons"".""Name"", ""Persons"".""Midname"",""Persons"".""Surname"",""Persons"".""Address"",""Persons"".""Email"",""Persons"".""PhoneNumber""
                            FROM ""Teachers""
                            LEFT JOIN ""Persons"" ON ""Persons"".""Id"" = ""Teachers"".""PersonId""
                            ORDER BY ""Teachers"".""DateCreate"" ASC";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetTeacherResponse>(querry).ToList();
            }
        }
        public GetTeacherResponse Get(Guid id)
        {
            string querry = $@"SELECT ""Teachers"".""Id"", 
                            ""Persons"".""Name"", ""Persons"".""Midname"",""Persons"".""Surname"",""Persons"".""Address"",""Persons"".""Email"",""Persons"".""PhoneNumber""
                            FROM ""Teachers""
                            LEFT JOIN ""Persons"" ON ""Persons"".""Id"" = ""Teachers"".""PersonId""
                            WHERE ""Teachers"".""Id""='{id}'";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetTeacherResponse>(querry).FirstOrDefault();
            }
        }
    }
}

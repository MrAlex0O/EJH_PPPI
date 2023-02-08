using Dapper;
using DataBase.Models;
using Logic.DTOs.Group;
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
    /// <summary>
    /// Запросы групп
    /// </summary>
    public class GroupQuery : IGroupQuery
    {
        /// <summary>
        /// Строка подключения к БД
        /// </summary>
        string _connectionString;
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="configuration">Файл конфигураций</param>
        public GroupQuery(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        /// <summary>
        /// Получить все группы
        /// </summary>
        /// <returns>Список групп</returns>
        public List<GetGroupResponse> GetAll()
        {
            string querry = $@"SELECT ""Id"", ""Name"" FROM ""Groups""
                                ORDER BY ""DateCreate"" ASC";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetGroupResponse>(querry).ToList();
            }
        }
        /// <summary>
        /// Получить группу по id
        /// </summary>
        /// <param name="id">id группы</param>
        /// <returns>Группа по id</returns>
        public GetGroupResponse Get(Guid id)
        {
            string querry = $@"SELECT ""Id"", ""Name"" FROM ""Groups""
                                WHERE ""Id"" = '{id}'";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<GetGroupResponse>(querry).FirstOrDefault();
            }
        }
    }
}

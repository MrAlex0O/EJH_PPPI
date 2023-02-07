using API.Authorization.Models;
using Dapper;
using System.Data;

namespace API.Authorization.Queries
{
    public class UserQuery : IUserQuery
    {
        string _connectionString;
        public UserQuery(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public List<string> GetRolesByUser(Guid id)
        {
            string querry = $@"SELECT ""Roles"".""Name"" FROM ""UserRoles""
INNER JOIN ""Roles"" ON ""Roles"".""Id"" = ""UserRoles"".""RoleId""
WHERE ""UserRoles"".""UserId"" = '{id}'
";

            using (IDbConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                return db.Query<string>(querry).ToList();
            }
        }
    }
}

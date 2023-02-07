using DataBase.Models;

namespace API.Authorization.Services
{
    public interface IJwtService
    {
        public string GenerateToken(User user);
        public Guid? ValidateToken(string token);
    }
}

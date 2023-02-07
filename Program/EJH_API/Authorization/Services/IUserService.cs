using API.Authorization.Models.Users;
using DataBase.Models;

namespace API.Authorization.Services
{
    public interface IUserService
    {
        AuthResponse Authenticate(AuthRequest model);
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        bool Register(RegisterRequest model);
        void Update(Guid id, UpdateRequest model);
        void Delete(Guid id);
        public Guid[] GetUserRoles(Guid id);
        public List<RoleResponse> GetRoles();
    }
}

using AutoMapper;
using DataBase.Contexts;
using DataBase.Models;
using Org.BouncyCastle.Crypto.Generators;
using BCrypt.Net;
using DataBase.Repositories.Interfaces;
using API.Authorization.Queries;
using API.Authorization.Models.Users;

namespace API.Authorization.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWorkRepository _repository;
        private IJwtService _jwtUtils;
        private readonly IMapper _mapper;
        private IUserQuery _userQuery;

        public UserService(IUnitOfWorkRepository repository, IJwtService jwtUtils, IMapper mapper, IUserQuery userQuery)
        {
            _repository = repository;
            _jwtUtils = jwtUtils;
            _mapper = mapper;
            _userQuery = userQuery;
        }

        public AuthResponse Authenticate(AuthRequest model)
        {
            User user = _repository.Users.GetAll().FirstOrDefault(x => x.Username == model.Username);

            // validate
            if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
                throw new Exception("Username or password is incorrect");           //#TODO

            // authentication successful
            AuthResponse response = _mapper.Map<AuthResponse>(user);
            Person person = _repository.Persons.Get(user.PersonId);
            response.Surname = person.Surname;
            response.Name = person.Name;
            response.Token = _jwtUtils.GenerateToken(user);
            response.Roles = _userQuery.GetRolesByUser(user.Id).ToArray();

            return response;
        }
        public IEnumerable<User> GetAll()
        {
            return _repository.Users.GetAll();
        }

        public User GetById(Guid id)
        {
            return getUser(id);
        }

        public bool Register(RegisterRequest model)
        {
            // validate
            if (_repository.Users.GetAll().Any(x => x.Username == model.Username))
                return false;

            // map model to new user object
            User user = _mapper.Map<User>(model);
            Person person = _mapper.Map<Person>(model);
            // hash password
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password);



            // save user
            person = _repository.Persons.Add(person);
            user.PersonId = person.Id;
            user = _repository.Users.Add(user);
            Role role = _repository.Roles.GetAll().Where(i => i.Name == model.Role).FirstOrDefault();
            UserRole userRole = new UserRole() { UserId = user.Id, RoleId = role.Id };
            _repository.UserRoles.Add(userRole);
            _repository.SaveChanges();
            return true;
        }


        public void Update(Guid id, UpdateRequest model)
        {
            var user = getUser(id);

            // validate
            if (model.Username != user.Username && _repository.Users.GetAll().Any(x => x.Username == model.Username))
                throw new Exception("Username '" + model.Username + "' is already taken");  //#TODO

            // hash password if it was entered
            if (!string.IsNullOrEmpty(model.Password))
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password);

            // copy model to user and save
            _mapper.Map(model, user);
            _repository.Users.Update(user);
            _repository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var user = getUser(id);
            _repository.Users.Delete(user);
            _repository.SaveChanges();
        }

        // helper methods

        private User getUser(Guid id)
        {
            var user = _repository.Users.Get(id);
            if (user == null) throw new KeyNotFoundException("User not found");     //#TODO
            return user;
        }
        public Guid[] GetUserRoles(Guid id)
        {
            UserRole[] roles = _repository.UserRoles.GetAll().Where(i => i.UserId == id).ToArray();
            List<Guid> result = new List<Guid>();
            foreach (var role in roles)
            {
                result.Add(role.RoleId);
            }
            return result.ToArray();

        }


        public List<RoleResponse> GetRoles()
        {
            List<RoleResponse> result = new List<RoleResponse>();
            List<Role> roles = _repository.Roles.GetAll();
            foreach (Role role in roles)
            {
                result.Add(_mapper.Map<RoleResponse>(role));
            }
            return result;
        }

    }
}

using API.Authorization.Models.Users;
using AutoMapper;
using DataBase.Models;

namespace API.Authorization.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, AuthResponse>();
            CreateMap<Person, AuthResponse>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null)); ;
            CreateMap<AuthResponse, Person>();
            CreateMap<RegisterRequest, User>();
            CreateMap<UpdateRequest, User>();
            CreateMap<RegisterRequest, Person>();
            CreateMap<UpdateRequest, Person>();
            CreateMap<Role, RoleResponse>();
        }
    }
}

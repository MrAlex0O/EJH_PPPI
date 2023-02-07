using AutoMapper;
using DataBase.Models;
using Logic.DTOs.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<CreateTeacherRequest, Person>();
            CreateMap<UpdateTeacherRequest, Person>();
            CreateMap<UpdateTeacherRequest, Teacher>();
        }
    }
}

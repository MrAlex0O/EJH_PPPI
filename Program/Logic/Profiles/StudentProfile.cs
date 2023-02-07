using AutoMapper;
using DataBase.Models;
using Logic.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<CreateStudentRequest, Person>();
            CreateMap<UpdateStudentRequest, Person>();
            CreateMap<UpdateStudentRequest, Student>();
        }
    }
}

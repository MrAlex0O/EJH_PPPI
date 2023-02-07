using AutoMapper;
using DataBase.Models;
using Logic.DTOs.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
    public class LessonProfile : Profile
    {
        public LessonProfile()
        {
            CreateMap<CreateLessonRequest, Lesson>();
            CreateMap<UpdateLessonRequest, Lesson>();
        }
    }
}

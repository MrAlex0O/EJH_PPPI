using AutoMapper;
using DataBase.Models;
using Logic.DTOs.LessonVisitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
	//профиль трансляции объектов сущности "посещение"
    public class LessonVisitorsProfile : Profile
    {
        public LessonVisitorsProfile()
        {
            CreateMap<CreateLessonVisitorRequest, LessonVisitor>();
            CreateMap<UpdateLessonVisitorRequest, LessonVisitor>();
        }
    }
}

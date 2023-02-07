using AutoMapper;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Logic.DTOs.Lesson;
using Logic.WriteServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices
{
    public class LessonWriteService : ILessonWriteService
    {
        private IUnitOfWorkRepository _repositories;
        readonly IMapper _mapper;
        public LessonWriteService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        public Guid Add(CreateLessonRequest createLessonRequest)
        {
            Guid id = _repositories.Lessons.Add(_mapper.Map<Lesson>(createLessonRequest)).Id;
            _repositories.SaveChanges();
            return id;
        }

        public void Update(Guid id, UpdateLessonRequest updateLessonRequest)
        {
            Lesson lesson = _repositories.Lessons.Get(id);
            _mapper.Map<UpdateLessonRequest, Lesson>(updateLessonRequest, lesson);
            _repositories.Lessons.Update(lesson);
            _repositories.SaveChanges();
        }
        public void Delete(Guid id)
        {
            Lesson lesson = _repositories.Lessons.Get(id);
            _repositories.Lessons.Delete(lesson);
            _repositories.SaveChanges();
        }
    }
}

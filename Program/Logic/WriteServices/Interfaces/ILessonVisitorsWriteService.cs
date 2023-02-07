using DataBase.Models;
using Logic.DTOs.LessonVisitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices.Interfaces
{
    public interface ILessonVisitorWriteService
    {
        public void Add(CreateLessonVisitorRequest createlessonsVisitors);
        public void Update(Guid id, UpdateLessonVisitorRequest updatelessonsVisitors);
        public void Delete(Guid id);
    }
}

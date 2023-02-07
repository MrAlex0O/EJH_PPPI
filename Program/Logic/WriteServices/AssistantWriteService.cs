using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Logic.WriteServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices
{
    public class AssistantWriteService : IAssistantWriteService
    {
        IUnitOfWorkRepository _repositories;
        public AssistantWriteService(IUnitOfWorkRepository repositories)
        {
            _repositories = repositories;
        }

        public Guid Add(Guid disciplineId, Guid teacherId)
        {
            Assistant assistant = new Assistant() { DisciplineId = disciplineId, TeacherId = teacherId };
            assistant = _repositories.Assistants.Add(assistant);
            _repositories.SaveChanges();
            return assistant.Id;
        }

        public void Delete(Guid disciplineId, Guid teacherId)
        {
            Assistant assistant = (Assistant)_repositories.Assistants.GetAll().Where(i => i.DisciplineId == disciplineId && i.TeacherId == teacherId);
            _repositories.Assistants.Delete(assistant);
            _repositories.SaveChanges();
        }

        public void DeleteByDisciplineId(Guid disciplineId)
        {
            List<Assistant> assistants = _repositories.Assistants.GetAll().Where(i => i.DisciplineId == disciplineId).ToList();
            foreach(var a in assistants)
            {
                _repositories.Assistants.Delete(a);
            }
            _repositories.SaveChanges();
        }
    }
}

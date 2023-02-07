using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices.Interfaces
{
    public interface IAssistantWriteService
    {
        public Guid Add(Guid disciplineId, Guid teacherId);
        public void Delete(Guid disciplineId, Guid teacherId);
        public void DeleteByDisciplineId(Guid disciplineId);
    }
}

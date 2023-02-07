using Logic.DTOs.Discipline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices.Interfaces
{
    public interface IDisciplineWriteService
    {
        public Guid Add(CreateDisciplineRequest createDisciplineRequest);
        public void Update(Guid id, UpdateDisciplineRequest updateDisciplineRequest);
        public void Delete(Guid id);
    }
}

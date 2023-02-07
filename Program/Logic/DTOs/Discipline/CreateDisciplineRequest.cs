using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.Discipline
{
    public class CreateDisciplineRequest
    {
        public string Name { get; set; }
        public Guid LectorId { get; set; }
        public Guid GroupId { get; set; }
        public Guid[]? AssistantsIds { get; set; } 
        public int Semester { get; set; }
    }
}

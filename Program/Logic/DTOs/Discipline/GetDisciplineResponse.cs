using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.Discipline
{
    public class GetDisciplineResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid LectorId { get; set; }
        public string LectorFullName { get; set; }
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public int Semester { get; set; }
        public Guid[] AssistantsIds { get; set; }
        public string[] AssistantsFullNames { get; set; }

    }
}

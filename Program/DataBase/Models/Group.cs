using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class Group : BaseModel
    {
        public string Name { get; set; }
        public IEnumerable<Student> Studnets { get; set; }
        public IEnumerable<Discipline> Disciplines { get; set; }

    }
}

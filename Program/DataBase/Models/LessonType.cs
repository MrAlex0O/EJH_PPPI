using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class LessonType : BaseModel
    {
        public string Name { get; set; }
        public int EnumId { get; set; }
    }
}

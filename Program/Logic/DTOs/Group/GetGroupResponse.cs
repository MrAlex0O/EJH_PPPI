using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.Group
{
	//получить ответ на запрос получения группы
    public class GetGroupResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

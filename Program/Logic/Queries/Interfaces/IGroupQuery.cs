using DataBase.Models;
using Logic.DTOs.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Queries.Interfaces
{
    public interface IGroupQuery
    {
        public List<GetGroupResponse> GetAll();
        public GetGroupResponse Get(Guid id);
    }
}

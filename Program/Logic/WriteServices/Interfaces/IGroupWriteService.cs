using Logic.DTOs.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices
{
    public interface IGroupWriteService
    {
        public void Add(CreateGroupRequest createGroupRequest);
        public void Update(Guid id, UpdateGroupRequest updateGroupRequest);
        public void Delete(Guid id);
    }
}

using AutoMapper;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Logic.DTOs.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices
{
    public class GroupWriteService : IGroupWriteService
    {
        private IUnitOfWorkRepository _repositories;
        readonly IMapper _mapper;
        public GroupWriteService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        public void Add(CreateGroupRequest createGroupRequest)
        {
            _repositories.Groups.Add(_mapper.Map<Group>(createGroupRequest));
            _repositories.SaveChanges();
        }

        public void Update(Guid id, UpdateGroupRequest updateGroupRequest)
        {
            Group group = _repositories.Groups.Get(id);
            
            _mapper.Map<UpdateGroupRequest, Group>(updateGroupRequest, group);
            _repositories.Groups.Update(group);
            _repositories.SaveChanges();
        }
        public void Delete(Guid id)
        {
            Group group = _repositories.Groups.Get(id);
            _repositories.Groups.Delete(group);
            _repositories.SaveChanges();
        }
    }
}

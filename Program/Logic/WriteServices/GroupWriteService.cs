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
    /// <summary>
    /// Сервис обработки групп
    /// </summary>
    public class GroupWriteService : IGroupWriteService
    {
        /// <summary>
        /// Общий репозиторий
        /// </summary>
        private IUnitOfWorkRepository _repositories;
        /// <summary>
        /// Конвертор моделей
        /// </summary>
        readonly IMapper _mapper;
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="repositories">Общий репозиторий</param>
        /// <param name="mapper">Конвертор моделей</param>
        public GroupWriteService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }
        /// <summary>
        /// Создать группу
        /// </summary>
        /// <param name="createGroupRequest">Модель создания группы</param>
        public void Add(CreateGroupRequest createGroupRequest)
        {
            _repositories.Groups.Add(_mapper.Map<Group>(createGroupRequest));
            _repositories.SaveChanges();
        }
        /// <summary>
        /// Обновить группу по id
        /// </summary>
        /// <param name="id">id группы для обновления</param>
        /// <param name="updateGroupRequest">Модель для обновления</param>
        public void Update(Guid id, UpdateGroupRequest updateGroupRequest)
        {
            Group group = _repositories.Groups.Get(id);
            
            _mapper.Map<UpdateGroupRequest, Group>(updateGroupRequest, group);
            _repositories.Groups.Update(group);
            _repositories.SaveChanges();
        }
        /// <summary>
        /// Удалить группу по id
        /// </summary>
        /// <param name="id">id группы для удаления</param>
        public void Delete(Guid id)
        {
            Group group = _repositories.Groups.Get(id);
            _repositories.Groups.Delete(group);
            _repositories.SaveChanges();
        }
    }
}

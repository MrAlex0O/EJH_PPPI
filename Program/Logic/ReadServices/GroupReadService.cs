using Logic.DTOs.Group;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    /// <summary>
    /// Сервис чтения групп
    /// </summary>
    public class GroupReadService : IGroupReadService
    {
        /// <summary>
        /// Запросы групп
        /// </summary>
        IGroupQuery _groupQuery;
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="query">Запросы групп</param>
        public GroupReadService(IGroupQuery query)
        {
            _groupQuery = query;
        }
        /// <summary>
        /// Получить все группы
        /// </summary>
        /// <returns>Список групп</returns>
        public List<GetGroupResponse> GetAll()
        {
            return _groupQuery.GetAll();
        }
        /// <summary>
        /// Получить группу по id
        /// </summary>
        /// <param name="id">id группы</param>
        /// <returns>Группа по id</returns>
        public GetGroupResponse Get(Guid id)
        {
            return _groupQuery.Get(id);
        }
    }
}

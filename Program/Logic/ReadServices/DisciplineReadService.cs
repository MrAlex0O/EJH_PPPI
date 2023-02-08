using Logic.DTOs.Discipline;
using Logic.Queries.Interfaces;
using Logic.ReadServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ReadServices
{
    public class DisciplineReadService : IDisciplineReadService
    {
        /// <summary>
        /// Запросы дисциплин
        /// </summary>
        IDisciplineQuery _disciplineQuery;
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="disciplineQuery">Запросы дисциплин</param>
        public DisciplineReadService(IDisciplineQuery disciplineQuery)
        {
            _disciplineQuery = disciplineQuery;
        }
        /// <summary>
        /// Получить все дисциплины
        /// </summary>
        /// <returns>Список дисцилин</returns>
        public List<GetDisciplineResponse> GetAll()
        {
            return _disciplineQuery.GetAll();
        }
        /// <summary>
        /// Получить дисциплину по id
        /// </summary>
        /// <param name="id">id дисциплины</param>
        /// <returns>Дисциплина по id</returns>
        public GetDisciplineResponse Get(Guid id)
        {
            return _disciplineQuery.Get(id);
        }
        /// <summary>
        /// Получить дисцилины по id преподавателя
        /// </summary>
        /// <param name="teacherId">id преподавателя</param>
        /// <returns>Список дисциплин по id преподавателя</returns>
        public List<GetDisciplineResponse> GetByTeacherId(Guid teacherId)
        {
            return _disciplineQuery.GetByTeacherId(teacherId);
        }
    }
}

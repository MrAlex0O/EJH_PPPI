using AutoMapper;
using DataBase.Models;
using DataBase.Repositories.Interfaces;
using Logic.DTOs.Discipline;
using Logic.WriteServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices
{
    /// <summary>
    /// Сервис обработки дисциплин
    /// </summary>
    public class DisciplineWriteService : IDisciplineWriteService
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
        public DisciplineWriteService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }
        /// <summary>
        /// Создать дисциплину
        /// </summary>
        /// <param name="createDisciplineRequest">Модель создания дисциплины</param>
        /// <returns>id добавленной дисциплины</returns>
        public Guid Add(CreateDisciplineRequest createDisciplineRequest)
        {
            Guid id = _repositories.Disciplines.Add(_mapper.Map<Discipline>(createDisciplineRequest)).Id;
            _repositories.SaveChanges();
            return id;
        }
        /// <summary>
        /// Обновить дисциплину по id
        /// </summary>
        /// <param name="id">id дисциплины для обновления</param>
        /// <param name="updateDisciplineRequest">Модель для обновления</param>
        public void Update(Guid id, UpdateDisciplineRequest updateDisciplineRequest)
        {
            Discipline discipline = _repositories.Disciplines.Get(id);
            _mapper.Map<UpdateDisciplineRequest, Discipline>(updateDisciplineRequest, discipline);
            _repositories.Disciplines.Update(discipline);
            _repositories.SaveChanges();
        }
        /// <summary>
        /// Удалить дисциплину по id
        /// </summary>
        /// <param name="id">id дисциплины для удаления</param>
        public void Delete(Guid id)
        {
            Discipline discipline = _repositories.Disciplines.Get(id);
            _repositories.Disciplines.Delete(discipline);
            _repositories.SaveChanges();
        }
    }
}

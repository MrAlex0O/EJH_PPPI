using Logic.DTOs.Discipline;
using Logic.ReadServices.Interfaces;
using Logic.WriteServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    /// <summary>
    /// HTTP-контроллер дисциплин
    /// </summary>
    //[Authorization.Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplineController : ControllerBase
    {
        IDisciplineWriteService _disciplineWriteService;
        IDisciplineReadService _disciplineReadService;
        IAssistantWriteService _assistantWriteService;
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="disciplineWriteService">Сервис записи дисциплин</param>
        /// <param name="disciplineReadService">Сервис чтения дисциплин</param>
        /// <param name="assistantWriteService">Сервис записи ассистентов</param>
        public DisciplineController(IDisciplineWriteService disciplineWriteService, IDisciplineReadService disciplineReadService, IAssistantWriteService assistantWriteService)
        {
            _disciplineWriteService = disciplineWriteService;
            _disciplineReadService = disciplineReadService;
            _assistantWriteService = assistantWriteService;
        }

        /// <summary>
        /// Получение дисциплин
        /// </summary>
        /// <returns>Все дисциплины</returns>
        // GET api/<DisciplineController>
        [HttpGet]
        public async Task<ActionResult<List<GetDisciplineResponse>>> Get()
        {
            try
            {
                return Ok(_disciplineReadService.GetAll());
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Получение дисциплины по id
        /// </summary>
        /// <param name="id">id дисциплины</param>
        /// <returns>Дисциплина по id</returns>
        // GET api/<DisciplineController>
        [HttpGet("{id}")]
        [Authorization.Attributes.AllowAnonymous]
        public async Task<ActionResult<GetDisciplineResponse>> Get(Guid id)
        {
            try
            {
                return Ok(_disciplineReadService.Get(id));
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Получение дисциплин по id учителя
        /// </summary>
        /// <param name="teacherId">id учителя</param>
        /// <returns>Дисциплины по id учителя</returns>
        // GET api/<DisciplineController>/5
        [HttpGet("byTeacherId/{teacherId}")]
        [Authorization.Attributes.AllowAnonymous]
        public async Task<ActionResult<List<GetDisciplineResponse>>> GetByTeacherId(Guid teacherId)
        {
            try
            {
                return Ok(_disciplineReadService.GetByTeacherId(teacherId));
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Создание дисциплины
        /// </summary>
        /// <param name="createDisciplineRequest">Модель дисциплины</param>
        /// <returns>Статус запроса</returns>
        // POST api/<DisciplineController>
        [HttpPost]
        [Authorization.Attributes.AllowAnonymous]
        public async Task<ActionResult> Post([FromBody] CreateDisciplineRequest createDisciplineRequest)
        {
            try
            {
                Guid disciplineId = _disciplineWriteService.Add(createDisciplineRequest);
                foreach (var assistantId in createDisciplineRequest.AssistantsIds)
                {
                    _assistantWriteService.Add(disciplineId, assistantId);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Обновление дисциплины по id
        /// </summary>
        /// <param name="id">id дисциплины</param>
        /// <param name="updateDisciplineRequest">Новые данные</param>
        /// <returns>Статус запроса</returns>
        // PUT api/<DisciplineController>
        [HttpPut("{id}")]
        [Authorization.Attributes.AllowAnonymous]
        public async Task<ActionResult> Put(Guid id, [FromBody] UpdateDisciplineRequest updateDisciplineRequest)
        {
            try
            {
                _disciplineWriteService.Update(id, updateDisciplineRequest);
                _assistantWriteService.DeleteByDisciplineId(id); 
                foreach (var assistantId in updateDisciplineRequest.AssistantsIds)
                {
                    _assistantWriteService.Add(id, assistantId);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Удаление дисциплины по id
        /// </summary>
        /// <param name="id">id дисциплины</param>
        /// <returns>Статус запроса</returns>
        // DELETE api/<DisciplineController>
        [HttpDelete("{id}")]
        [Authorization.Attributes.AllowAnonymous]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                _disciplineWriteService.Delete(id);
                _assistantWriteService.DeleteByDisciplineId(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}

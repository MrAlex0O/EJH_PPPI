using Microsoft.AspNetCore.Mvc;
using Logic.WriteServices;
using Logic.DTOs.Group;
using Logic.ReadServices.Interfaces;
using DataBase.Contexts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    /// <summary>
    /// HTTP-контроллер для групп
    /// </summary>
    [Authorization.Attributes.Authorize( Roles.Admin )]
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        /// <summary>
        /// Сервис записи групп
        /// </summary>
        IGroupWriteService _groupWriteService;
        /// <summary>
        /// Сервис чтения групп
        /// </summary>
        IGroupReadService _groupReadService;
        /// <summary>
        /// Конструктор с DI
        /// </summary>
        /// <param name="groupWriteService">Сервис записи групп</param>
        /// <param name="groupReadService">Сервис чтения групп</param>
        public GroupController(IGroupWriteService groupWriteService, IGroupReadService groupReadService)
        {
            _groupWriteService = groupWriteService;
            _groupReadService = groupReadService;
        }
        /// <summary>
        /// Получение всех групп
        /// </summary>
        /// <returns>Все группы</returns>
        // GET api/<GroupController>
        [HttpGet]
        [Authorization.Attributes.Authorize( Roles.Student)]
        public async Task<ActionResult<List<GetGroupResponse>>> Get()
        {
            try
            {
                return Ok(_groupReadService.GetAll());

            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Получение группы по id
        /// </summary>
        /// <param name="id">id группы</param>
        /// <returns>Группа по id</returns>
        // GET api/<GroupController>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetGroupResponse>> Get(Guid id)
        {
            try
            {
                return Ok(_groupReadService.Get(id));

            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Добавить группу
        /// </summary>
        /// <param name="createGroupRequest">Модель группы</param>
        /// <returns>Статус запроса</returns>
        // POST api/<GroupController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateGroupRequest createGroupRequest)
        {
            try
            {
                _groupWriteService.Add(createGroupRequest);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Обновление группы по id
        /// </summary>
        /// <param name="id">id группы</param>
        /// <param name="updateGroupRequest">Новые данные</param>
        /// <returns>Статус запроса</returns>
        // PUT api/<GroupController>
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] UpdateGroupRequest updateGroupRequest)
        {
            try
            {
                _groupWriteService.Update(id, updateGroupRequest);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Удалить группу по id
        /// </summary>
        /// <param name="id">id группы</param>
        /// <returns>Статус запроса</returns>
        // DELETE api/<GroupController>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                _groupWriteService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}

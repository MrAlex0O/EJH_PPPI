using Microsoft.AspNetCore.Mvc;
using Logic.WriteServices;
using Logic.DTOs.Group;
using Logic.ReadServices.Interfaces;
using DataBase.Contexts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Authorization.Attributes.Authorize( Roles.Admin )]
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        IGroupWriteService _groupWriteService;
        IGroupReadService _groupReadService;
        public GroupController(IGroupWriteService groupWriteService, IGroupReadService groupReadService)
        {
            _groupWriteService = groupWriteService;
            _groupReadService = groupReadService;
        }


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

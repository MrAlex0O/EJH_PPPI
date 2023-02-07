using AutoMapper;
using DataBase.Models;
using Logic.DTOs.Student;
using Logic.ReadServices.Interfaces;
using Logic.WriteServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IPersonWriteService _personWriteService;
        IStudentWriteService _studentWriteService;
        IStudentReadService _studentReadService;
        IMapper _mapper;
        public StudentController(IPersonWriteService personWriteService, IStudentWriteService studentWriteService, IMapper mapper, IStudentReadService studentReadService)
        {
            _personWriteService = personWriteService;
            _studentWriteService = studentWriteService;
            _studentReadService = studentReadService;
            _mapper = mapper;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<ActionResult<List<GetStudentResponse>>> Get()
        {
            try
            {
                return Ok(_studentReadService.GetAll());
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetStudentResponse>> Get(Guid id)
        {
            try
            {
                return Ok(_studentReadService.Get(id));
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        // GET api/<StudentController>/5
        [HttpGet("byGroupId/{groupId}")]
        public async Task<ActionResult<List<GetStudentResponse>>> GetByGroupId(Guid groupId)
        {
            try
            {
                return Ok(_studentReadService.GetByGroupId(groupId));
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        // POST api/<StudentController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateStudentRequest createStudentRequest)
        {
            try
            {
                Guid personId = _personWriteService.Add(_mapper.Map<Person>(createStudentRequest));
                _studentWriteService.Add(personId, createStudentRequest.GroupId);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] UpdateStudentRequest updateStudentRequest)
        {
            try
            {
                Guid personId = (Guid)_studentWriteService.Update(id, updateStudentRequest).PersonId;
                _personWriteService.Update(personId, _mapper.Map<Person>(updateStudentRequest));

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                Guid personId = (Guid)_studentWriteService.Delete(id).PersonId;
                _personWriteService.Delete(personId);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}

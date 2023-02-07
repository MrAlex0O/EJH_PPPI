using AutoMapper;
using DataBase.Models;
using Logic.DTOs.Teacher;
using Logic.ReadServices.Interfaces;
using Logic.WriteServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        IPersonWriteService _personWriteService;
        ITeacherWriteService _teacherWriteService;
        ITeacherReadService _teacherReadService;
        IMapper _mapper;
        public TeacherController(IPersonWriteService personWriteService, ITeacherWriteService teacherWriteService, ITeacherReadService teacherReadService, IMapper mapper)
        {
            _personWriteService = personWriteService;
            _teacherWriteService = teacherWriteService;
            _teacherReadService = teacherReadService;
            _mapper = mapper;
        }
        // GET: api/<TeacherController>
        [HttpGet]
        public async Task<ActionResult<List<GetTeacherResponse>>> Get()
        {
            try
            {
                return Ok(_teacherReadService.GetAll());
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetTeacherResponse>> Get(Guid id)
        {
            try
            {
                return Ok(_teacherReadService.Get(id));
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateTeacherRequest createTeacherRequest)
        {
            try
            {
                Guid personId = _personWriteService.Add(_mapper.Map<Person>(createTeacherRequest));
                _teacherWriteService.Add(personId);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] UpdateTeacherRequest updateTeacherRequest)
        {
            try
            {
                Guid personId = (Guid)_teacherWriteService.Update(id, updateTeacherRequest).PersonId;
                _personWriteService.Update(personId, _mapper.Map<Person>(updateTeacherRequest));

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
                Guid personId = (Guid)_teacherWriteService.Delete(id).PersonId;
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

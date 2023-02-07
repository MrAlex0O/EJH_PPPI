using Logic.DTOs.Lesson;
using Logic.ReadServices.Interfaces;
using Logic.WriteServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        ILessonWriteService _lessonWriteService;
        IAssistantWriteService _assistantWriteService;
        ILessonReadService _lessonReadService;
        public LessonController(ILessonWriteService lessonWriteService, IAssistantWriteService assistantWriteService, ILessonReadService lessonReadService )
        {
            _lessonWriteService = lessonWriteService;
            _assistantWriteService = assistantWriteService;
            _lessonReadService = lessonReadService;
        }
        // GET api/<LessonController>
        [HttpGet]
        public async Task<ActionResult<List<GetLessonResponse>>> Get()
        {
            try
            {
                return Ok(_lessonReadService.GetAll());
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // GET api/<LessonController>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetLessonResponse>> Get(Guid id)
        {
            try
            {
                return Ok(_lessonReadService.Get(id));
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        // POST api/<LessonController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLessonRequest createLessonRequest)
        {
            try
            {
                Guid lessonId = _lessonWriteService.Add(createLessonRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // PUT api/<LessonController>
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] UpdateLessonRequest updateLessonRequest)
        {
            try
            {
                _lessonWriteService.Update(id, updateLessonRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // DELETE api/<LessonController>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                _lessonWriteService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}

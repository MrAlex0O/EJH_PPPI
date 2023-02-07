using Logic.DTOs.LessonVisitors;
using Logic.ReadServices.Interfaces;
using Logic.WriteServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonVisitorController : ControllerBase
    {
        ILessonVisitorWriteService _lessonVisitorWriteService;
        ILessonVisitorReadService _lessonVisitorsReadService;
        public LessonVisitorController(ILessonVisitorWriteService groupWriteService, ILessonVisitorReadService lessonVisitorsReadService)
        {
            _lessonVisitorWriteService = groupWriteService;
            _lessonVisitorsReadService = lessonVisitorsReadService;
        }
        // GET: api/<LessonVisitorController>
        [HttpGet]
        public async Task<ActionResult<List<GetLessonVisitorResponse>>> Get()
        {
            try
            {
                return Ok(_lessonVisitorsReadService.GetAll());
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // GET api/<LessonVisitorController>/5
        [HttpGet("byLessonId/{id}")]
        public async Task<ActionResult<GetLessonVisitorResponse>> Get(Guid id)
        {
            try
            {
                return Ok(_lessonVisitorsReadService.GetByLessonId(id));

                
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // POST api/<LessonVisitorController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLessonVisitorRequest createLessonVisitorRequest)
        {
            try
            {
                _lessonVisitorWriteService.Add(createLessonVisitorRequest);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // PUT api/<LessonVisitorController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] UpdateLessonVisitorRequest updateLessonVisitorRequest)
        {
            try
            {
                _lessonVisitorWriteService.Update(id, updateLessonVisitorRequest);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // DELETE api/<LessonVisitorController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                _lessonVisitorWriteService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}

using Logic.DTOs.StatusOnLesson;
using Logic.ReadServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusOnLessonController : ControllerBase
    {
        IStatusOnLessonReadService _statusOnLessonReadService;
        public StatusOnLessonController(IStatusOnLessonReadService statusOnLessonReadService)
        {
            _statusOnLessonReadService = statusOnLessonReadService;
        }
        // GET: api/<StatusOnLessonController>
        [HttpGet]
        public async Task<ActionResult<List<GetStatusOnLessonResponse>>> Get()
        {
            try
            {
                return Ok(_statusOnLessonReadService.GetAll());
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // GET api/<StatusOnLessonController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetStatusOnLessonResponse>> Get(Guid id)
        {
            try
            {
                return Ok(_statusOnLessonReadService.Get(id));
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

    }
}

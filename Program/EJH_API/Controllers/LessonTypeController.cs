using Logic.DTOs.LessonType;
using Logic.ReadServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonTypeController : ControllerBase
    {
        ILessonTypeReadService _lessonTypeReadService;
        public LessonTypeController(ILessonTypeReadService lessonTypeReadService)
        {
            _lessonTypeReadService = lessonTypeReadService;
        }


        // GET api/<LessonTypeController>
        [HttpGet]
        public async Task<ActionResult<List<GetLessonTypeResponse>>> Get()
        {
            try
            {
                return Ok(_lessonTypeReadService.GetAll());

            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // GET api/<LessonTypeController>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetLessonTypeResponse>> Get(Guid id)
        {
            try
            {
                return Ok(_lessonTypeReadService.Get(id));

            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}

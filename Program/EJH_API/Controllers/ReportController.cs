using Microsoft.AspNetCore.Mvc;
using Logic.WriteServices;
using Logic.DTOs.Report;
using Logic.ReadServices.Interfaces;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    //[Authorization.Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportReadService _reportReadService;
        public ReportController(IReportReadService reportReadService)
        {
            _reportReadService = reportReadService;
        }

        // GET api/<ReportController>
        [HttpGet("disciplineVisits/{id}")]
        public async Task<ActionResult<GetDisciplineVisitsReportResponse>> GetDisciplineVisitsReport(Guid id)
        {
            try
            {
                return Ok(_reportReadService.GetDisciplineVisits(id));

            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        // GET api/<ReportController>
        [HttpGet("studentVisits/{id}")]
        public async Task<ActionResult<GetStudentVisitsResponse>> GetDisciplineVisitsByStudentId(Guid id)
        {
            try
            {
                return Ok(_reportReadService.GetDisciplineVisitsByStudentId(id));

            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        // POST api/<ReportController>
        [HttpPost("studentVisitsByDay")]
        public async Task<ActionResult<GetStudentVisitsResponse>> GetStudentVisitsByDay(GetStudentVisitByDayRequest request)
        {
            try
            {
                return Ok(_reportReadService.GetStudentVisitsByDay(request));

            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        // POST api/<ReportController>
        [HttpPost("studentVisitsByInterval")]
        public async Task<ActionResult<GetStudentVisitsResponse>> GetStudentVisitsByInterval(GetStudentVisitsByIntervalRequest request)
        {
            try
            {
                return Ok(_reportReadService.GetStudentVisitsByInterval(request));

            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

    }
}

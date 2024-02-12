using APIJobs.Application.InputModels.JobsInputModels;
using APIJobs.Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;

namespace APIJobs.API.Controllers
{
    [Route("api/job")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<IActionResult> GetJobs()
        {
            var jobs = await _jobService.GetJobs();
            if (jobs == null)
            {
                return NotFound();
            }
            return Ok(jobs);
        }

        [HttpGet("Id")]
        public async Task<ActionResult> GetJob(int Id)
        {
            var job = await _jobService.GetJobById(Id);
            
            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        [HttpPost]
        public async Task<ActionResult> PostJob([FromBody] CreateJobInputModel inputModel)
        {
            var id = await _jobService.CreateJob(inputModel);
            if(id == 0)
            {
                return BadRequest("Unable to create job. Try again!");
            }

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutJob([FromQuery] int id, [FromBody]UpdateJobInputModel inputModel)
        {
            var updated = await _jobService.UpdateJob(id, inputModel);

            if (updated == true)
            {
                return Ok();
            }

            return BadRequest("Unable to update job. Try again!");
            
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteJob([FromQuery] int Id)
        {
            var deleted = await _jobService.DeleteJob(Id);

            if(deleted == true)
            {
                return Ok();
            }

            return BadRequest("Unable to delete job. Try again!");
            
        }

    }
}

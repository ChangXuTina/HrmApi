using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HumanResource.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobRequirementController : ControllerBase
    {
        private readonly IJobRequirementServiceAsync JobRequirementServiceAsync;

        public JobRequirementController(IJobRequirementServiceAsync _JobRequirementServiceAsync)
        {
            JobRequirementServiceAsync = _JobRequirementServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await JobRequirementServiceAsync.GetAllJobRequirementsAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobRequirementRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await JobRequirementServiceAsync.AddJobRequirementAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(JobRequirementRequestModel model)
        {
            try
            {
                await JobRequirementServiceAsync.UpdateJobRequirementAsync(model);
                var updated = await JobRequirementServiceAsync.GetJobRequirementByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(JobRequirementResponseModel model)
        {
            await JobRequirementServiceAsync.DeleteJobRequirementAsync(model.Id);
            return NoContent();
        }

    }
}


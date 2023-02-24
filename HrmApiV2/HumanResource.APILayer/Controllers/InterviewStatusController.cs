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
    public class InterviewStatusController : ControllerBase
    {
        private readonly IInterviewStatusServiceAsync InterviewStatusServiceAsync;

        public InterviewStatusController(IInterviewStatusServiceAsync _InterviewStatusServiceAsync)
        {
            InterviewStatusServiceAsync = _InterviewStatusServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await InterviewStatusServiceAsync.GetAllInterviewStatusAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(InterviewStatusRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await InterviewStatusServiceAsync.AddInterviewStatusAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(InterviewStatusRequestModel model)
        {
            try
            {
                await InterviewStatusServiceAsync.UpdateInterviewStatusAsync(model);
                var updated = await InterviewStatusServiceAsync.GetInterviewStatusByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(InterviewStatusResponseModel model)
        {
            await InterviewStatusServiceAsync.DeleteInterviewStatusAsync(model.Id);
            return NoContent();
        }

    }
}


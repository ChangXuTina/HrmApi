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
    public class InterviewController : ControllerBase
    {
        private readonly IInterviewServiceAsync InterviewServiceAsync;

        public InterviewController(IInterviewServiceAsync _InterviewServiceAsync)
        {
            InterviewServiceAsync = _InterviewServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await InterviewServiceAsync.GetAllInterviewsAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(InterviewRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await InterviewServiceAsync.AddInterviewAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(InterviewRequestModel model)
        {
            try
            {
                await InterviewServiceAsync.UpdateInterviewAsync(model);
                var updated = await InterviewServiceAsync.GetInterviewByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(InterviewResponseModel model)
        {
            await InterviewServiceAsync.DeleteInterviewAsync(model.Id);
            return NoContent();
        }

    }
}


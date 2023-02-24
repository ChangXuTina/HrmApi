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
    public class InterviewTypeController : ControllerBase
    {
        private readonly IInterviewTypeServiceAsync InterviewTypeServiceAsync;

        public InterviewTypeController(IInterviewTypeServiceAsync _InterviewTypeServiceAsync)
        {
            InterviewTypeServiceAsync = _InterviewTypeServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await InterviewTypeServiceAsync.GetAllInterviewTypesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(InterviewTypeRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await InterviewTypeServiceAsync.AddInterviewTypeAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(InterviewTypeRequestModel model)
        {
            try
            {
                await InterviewTypeServiceAsync.UpdateInterviewTypeAsync(model);
                var updated = await InterviewTypeServiceAsync.GetInterviewTypeByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(InterviewTypeResponseModel model)
        {
            await InterviewTypeServiceAsync.DeleteInterviewTypeAsync(model.Id);
            return NoContent();
        }

    }
}


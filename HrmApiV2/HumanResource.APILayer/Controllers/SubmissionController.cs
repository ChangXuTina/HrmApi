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
    public class SubmissionController : ControllerBase
    {
        private readonly ISubmissionServiceAsync SubmissionServiceAsync;

        public SubmissionController(ISubmissionServiceAsync _SubmissionServiceAsync)
        {
            SubmissionServiceAsync = _SubmissionServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await SubmissionServiceAsync.GetAllSubmissionsAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SubmissionRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await SubmissionServiceAsync.AddSubmissiontAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(SubmissionRequestModel model)
        {
            try
            {
                await SubmissionServiceAsync.UpdateSubmissionAsync(model);
                var updated = await SubmissionServiceAsync.GetSubmissionByIdAsync(model.id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(SubmissionResponseModel model)
        {
            await SubmissionServiceAsync.DeleteSubmissionAsync(model.id);
            return NoContent();
        }

    }
}


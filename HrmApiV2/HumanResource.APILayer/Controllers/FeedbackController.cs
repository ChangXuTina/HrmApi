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
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackServiceAsync FeedbackServiceAsync;

        public FeedbackController(IFeedbackServiceAsync _FeedbackServiceAsync)
        {
            FeedbackServiceAsync = _FeedbackServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await FeedbackServiceAsync.GetAllFeedbacksAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(FeedbackRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await FeedbackServiceAsync.AddFeedbackAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(FeedbackRequestModel model)
        {
            try
            {
                await FeedbackServiceAsync.UpdateFeedbackAsync(model);
                var updated = await FeedbackServiceAsync.GetFeedbackByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(FeedbackResponseModel model)
        {
            await FeedbackServiceAsync.DeleteFeedbackAsync(model.Id);
            return NoContent();
        }

    }
}


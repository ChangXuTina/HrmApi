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
    public class JobCategoryController : ControllerBase
    {
        private readonly IJobCategoryServiceAsync JobCategoryServiceAsync;

        public JobCategoryController(IJobCategoryServiceAsync _JobCategoryServiceAsync)
        {
            JobCategoryServiceAsync = _JobCategoryServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await JobCategoryServiceAsync.GetAllJobCategoriesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await JobCategoryServiceAsync.AddJobCategoryAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(JobCategoryRequestModel model)
        {
            try
            {
                await JobCategoryServiceAsync.UpdateJobCategoryAsync(model);
                var updated = await JobCategoryServiceAsync.GetJobCategoryByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(JobCategoryResponseModel model)
        {
            await JobCategoryServiceAsync.DeleteJobCategoryAsync(model.Id);
            return NoContent();
        }

    }
}


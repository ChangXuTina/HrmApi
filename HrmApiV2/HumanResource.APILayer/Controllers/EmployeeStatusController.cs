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
    public class EmployeeStatusController : ControllerBase
    {
        private readonly IEmployeeStatusServiceAsync EmployeeStatusServiceAsync;

        public EmployeeStatusController(IEmployeeStatusServiceAsync _EmployeeStatusServiceAsync)
        {
            EmployeeStatusServiceAsync = _EmployeeStatusServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await EmployeeStatusServiceAsync.GetAllEmployeeStatusAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeStatusRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await EmployeeStatusServiceAsync.AddEmployeeStatusAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EmployeeStatusRequestModel model)
        {
            try
            {
                await EmployeeStatusServiceAsync.UpdateEmployeeStatusAsync(model);
                var updated = await EmployeeStatusServiceAsync.GetEmployeeStatusByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(EmployeeStatusResponseModel model)
        {
            await EmployeeStatusServiceAsync.DeleteEmployeeStatusAsync(model.Id);
            return NoContent();
        }

    }
}


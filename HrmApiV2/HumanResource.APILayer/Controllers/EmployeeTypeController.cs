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
    public class EmployeeTypeController : ControllerBase
    {
        private readonly IEmployeeTypeServiceAsync EmployeeTypeServiceAsync;

        public EmployeeTypeController(IEmployeeTypeServiceAsync _EmployeeTypeServiceAsync)
        {
            EmployeeTypeServiceAsync = _EmployeeTypeServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await EmployeeTypeServiceAsync.GetAllEmployeeTypesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeTypeRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await EmployeeTypeServiceAsync.AddEmployeeTypeAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EmployeeTypeRequestModel model)
        {
            try
            {
                await EmployeeTypeServiceAsync.UpdateEmployeeTypeAsync(model);
                var updated = await EmployeeTypeServiceAsync.GetEmployeeTypeByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(EmployeeTypeResponseModel model)
        {
            await EmployeeTypeServiceAsync.DeleteEmployeeTypeAsync(model.Id);
            return NoContent();
        }

    }
}


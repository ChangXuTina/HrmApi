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
    public class EmployeeRoleController : ControllerBase
    {
        private readonly IEmployeeRoleServiceAsync EmployeeRoleServiceAsync;

        public EmployeeRoleController(IEmployeeRoleServiceAsync _EmployeeRoleServiceAsync)
        {
            EmployeeRoleServiceAsync = _EmployeeRoleServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await EmployeeRoleServiceAsync.GetAllEmployeeRolesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeRoleRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await EmployeeRoleServiceAsync.AddEmployeeRoleAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EmployeeRoleRequestModel model)
        {
            try
            {
                await EmployeeRoleServiceAsync.UpdateEmployeeRoleAsync(model);
                var updated = await EmployeeRoleServiceAsync.GetEmployeeRoleByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(EmployeeRoleResponseModel model)
        {
            await EmployeeRoleServiceAsync.DeleteEmployeeRoleAsync(model.Id);
            return NoContent();
        }

    }
}


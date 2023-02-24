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
    public class RoleController : ControllerBase
    {
        private readonly IRoleServiceAsync RoleServiceAsync;

        public RoleController(IRoleServiceAsync _RoleServiceAsync)
        {
            RoleServiceAsync = _RoleServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await RoleServiceAsync.GetAllRolesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(RoleRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await RoleServiceAsync.AddRoleAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(RoleRequestModel model)
        {
            try
            {
                await RoleServiceAsync.UpdateRoleAsync(model);
                var updated = await RoleServiceAsync.GetRoleByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(RoleResponseModel model)
        {
            await RoleServiceAsync.DeleteRoleAsync(model.Id);
            return NoContent();
        }

    }
}


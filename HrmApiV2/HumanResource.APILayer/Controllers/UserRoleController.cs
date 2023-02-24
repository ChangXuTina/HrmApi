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
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleServiceAsync UserRoleServiceAsync;

        public UserRoleController(IUserRoleServiceAsync _UserRoleServiceAsync)
        {
            UserRoleServiceAsync = _UserRoleServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await UserRoleServiceAsync.GetAllUserRolesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserRoleRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await UserRoleServiceAsync.AddUserRoleAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(UserRoleRequestModel model)
        {
            try
            {
                await UserRoleServiceAsync.UpdateUserRoleAsync(model);
                var updated = await UserRoleServiceAsync.GetUserRoleByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(UserRoleResponseModel model)
        {
            await UserRoleServiceAsync.DeleteUserRoleAsync(model.Id);
            return NoContent();
        }

    }
}


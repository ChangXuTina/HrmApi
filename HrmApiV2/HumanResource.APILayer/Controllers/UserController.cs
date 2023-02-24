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
    public class UserController : ControllerBase
    {
        private readonly IUserServiceAsync UserServiceAsync;

        public UserController(IUserServiceAsync _UserServiceAsync)
        {
            UserServiceAsync = _UserServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await UserServiceAsync.GetAllUsersAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await UserServiceAsync.AddUserAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(UserRequestModel model)
        {
            try
            {
                await UserServiceAsync.UpdateUserAsync(model);
                var updated = await UserServiceAsync.GetUserByIdAsync(model.Id);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(UserResponseModel model)
        {
            await UserServiceAsync.DeleteUserAsync(model.Id);
            return NoContent();
        }

    }
}


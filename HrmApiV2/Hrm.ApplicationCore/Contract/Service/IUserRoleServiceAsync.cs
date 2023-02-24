using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IUserRoleServiceAsync
    {
        Task<int> AddUserRoleAsync(UserRoleRequestModel model);
        Task<int> UpdateUserRoleAsync(UserRoleRequestModel model);
        Task<int> DeleteUserRoleAsync(int id);
        Task<UserRoleResponseModel> GetUserRoleByIdAsync(int id);
        Task<IEnumerable<UserRoleResponseModel>> GetAllUserRolesAsync();

    }
}


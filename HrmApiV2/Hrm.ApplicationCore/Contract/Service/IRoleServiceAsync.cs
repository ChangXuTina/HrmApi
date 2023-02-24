using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IRoleServiceAsync
    {
        Task<int> AddRoleAsync(RoleRequestModel model);
        Task<int> UpdateRoleAsync(RoleRequestModel model);
        Task<int> DeleteRoleAsync(int id);
        Task<RoleResponseModel> GetRoleByIdAsync(int id);
        Task<IEnumerable<RoleResponseModel>> GetAllRolesAsync();

    }
}


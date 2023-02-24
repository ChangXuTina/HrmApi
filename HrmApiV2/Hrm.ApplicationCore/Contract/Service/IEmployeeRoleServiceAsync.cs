using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IEmployeeRoleServiceAsync
    {
        Task<int> AddEmployeeRoleAsync(EmployeeRoleRequestModel model);
        Task<int> UpdateEmployeeRoleAsync(EmployeeRoleRequestModel model);
        Task<int> DeleteEmployeeRoleAsync(int id);
        Task<EmployeeRoleResponseModel> GetEmployeeRoleByIdAsync(int id);
        Task<IEnumerable<EmployeeRoleResponseModel>> GetAllEmployeeRolesAsync();

    }
}


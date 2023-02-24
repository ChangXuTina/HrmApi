using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IEmployeeServiceAsync
    {
        Task<int> AddEmployeeAsync(EmployeeRequestModel model);
        Task<int> UpdateEmployeeAsync(EmployeeRequestModel model);
        Task<int> DeleteEmployeeAsync(int id);
        Task<EmployeeResponseModel> GetEmployeeByIdAsync(int id);
        Task<IEnumerable<EmployeeResponseModel>> GetAllEmployeesAsync();

    }
}


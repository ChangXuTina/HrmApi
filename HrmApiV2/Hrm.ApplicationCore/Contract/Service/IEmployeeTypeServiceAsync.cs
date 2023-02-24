using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IEmployeeTypeServiceAsync
    {
        Task<int> AddEmployeeTypeAsync(EmployeeTypeRequestModel model);
        Task<int> UpdateEmployeeTypeAsync(EmployeeTypeRequestModel model);
        Task<int> DeleteEmployeeTypeAsync(int id);
        Task<EmployeeTypeResponseModel> GetEmployeeTypeByIdAsync(int id);
        Task<IEnumerable<EmployeeTypeResponseModel>> GetAllEmployeeTypesAsync();

    }
}


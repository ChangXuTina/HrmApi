using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Entity;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.Infrastructure.Service
{
    public class EmployeeRoleServiceAsync : IEmployeeRoleServiceAsync
    {
        private readonly IEmployeeRoleRepositoryAsync employeeRoleRepositoryAsync;

        public EmployeeRoleServiceAsync(IEmployeeRoleRepositoryAsync _employeeRoleRepositoryAsync)
        {
            employeeRoleRepositoryAsync = _employeeRoleRepositoryAsync;
        }

        public Task<int> AddEmployeeRoleAsync(EmployeeRoleRequestModel model)
        {
            EmployeeRole employeeRole = new EmployeeRole()
            {
                Title = model.Title,
                Description = model.Description,
                IsActive = model.IsActive
            };
            return employeeRoleRepositoryAsync.InsertAsync(employeeRole);
        }

        public Task<int> DeleteEmployeeRoleAsync(int id)
        {
            return employeeRoleRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeRoleResponseModel>> GetAllEmployeeRolesAsync()
        {
            var result = await employeeRoleRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new EmployeeRoleResponseModel()
                { Id = x.Id, Description = x.Description, IsActive = x.IsActive, Title = x.Title });
            }
            return null;
        }

        public async Task<EmployeeRoleResponseModel> GetEmployeeRoleByIdAsync(int id)
        {
            var result = await employeeRoleRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new EmployeeRoleResponseModel()
                {
                    Id = result.Id,
                    Description = result.Description,
                    Title = result.Title,
                    IsActive = result.IsActive
                };
            }
            return null;

        }

        public Task<int> UpdateEmployeeRoleAsync(EmployeeRoleRequestModel model)
        {
            EmployeeRole employeeRole = new EmployeeRole()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                IsActive = model.IsActive
            };
            return employeeRoleRepositoryAsync.UpdateAsync(employeeRole);
        }
    }
}


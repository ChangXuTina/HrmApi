using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IJobCategoryServiceAsync
    {
        Task<int> AddJobCategoryAsync(JobCategoryRequestModel model);
        Task<int> UpdateJobCategoryAsync(JobCategoryRequestModel model);
        Task<int> DeleteJobCategoryAsync(int id);
        Task<JobCategoryResponseModel> GetJobCategoryByIdAsync(int id);
        Task<IEnumerable<JobCategoryResponseModel>> GetAllJobCategoriesAsync();

    }
}


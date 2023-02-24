using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IJobRequirementServiceAsync
    {
        Task<int> AddJobRequirementAsync(JobRequirementRequestModel model);
        Task<int> UpdateJobRequirementAsync(JobRequirementRequestModel model);
        Task<int> DeleteJobRequirementAsync(int id);
        Task<JobRequirementResponseModel> GetJobRequirementByIdAsync(int id);
        Task<IEnumerable<JobRequirementResponseModel>> GetAllJobRequirementsAsync();

    }
}


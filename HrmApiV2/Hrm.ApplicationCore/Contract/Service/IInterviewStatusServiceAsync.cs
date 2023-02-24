using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IInterviewStatusServiceAsync
    {
        Task<int> AddInterviewStatusAsync(InterviewStatusRequestModel model);
        Task<int> UpdateInterviewStatusAsync(InterviewStatusRequestModel model);
        Task<int> DeleteInterviewStatusAsync(int id);
        Task<InterviewStatusResponseModel> GetInterviewStatusByIdAsync(int id);
        Task<IEnumerable<InterviewStatusResponseModel>> GetAllInterviewStatusAsync();

    }
}


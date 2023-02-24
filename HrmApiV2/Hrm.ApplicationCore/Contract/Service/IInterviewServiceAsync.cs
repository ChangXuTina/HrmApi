using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IInterviewServiceAsync
    {
        Task<int> AddInterviewAsync(InterviewRequestModel model);
        Task<int> UpdateInterviewAsync(InterviewRequestModel model);
        Task<int> DeleteInterviewAsync(int id);
        Task<InterviewResponseModel> GetInterviewByIdAsync(int id);
        Task<IEnumerable<InterviewResponseModel>> GetAllInterviewsAsync();

    }
}


using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface ISubmissionServiceAsync
    {
        Task<int> AddSubmissiontAsync(SubmissionRequestModel model);
        Task<int> UpdateSubmissionAsync(SubmissionRequestModel model);
        Task<int> DeleteSubmissionAsync(int id);
        Task<SubmissionResponseModel> GetSubmissionByIdAsync(int id);
        Task<IEnumerable<SubmissionResponseModel>> GetAllSubmissionsAsync();

    }
}


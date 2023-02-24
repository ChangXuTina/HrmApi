using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface ICandidateServiceAsync
    {
        Task<int> AddCandidateAsync(CandidateRequestModel model);
        Task<int> UpdateCandidateAsync(CandidateRequestModel model);
        Task<int> DeleteCandidateAsync(int id);
        Task<CandidateResponseModel> GetCandidateByIdAsync(int id);
        Task<IEnumerable<CandidateResponseModel>> GetAllCandidatesAsync();
    }
}

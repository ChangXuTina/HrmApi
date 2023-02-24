using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IFeedbackServiceAsync
    {
        Task<int> AddFeedbackAsync(FeedbackRequestModel model);
        Task<int> UpdateFeedbackAsync(FeedbackRequestModel model);
        Task<int> DeleteFeedbackAsync(int id);
        Task<FeedbackResponseModel> GetFeedbackByIdAsync(int id);
        Task<IEnumerable<FeedbackResponseModel>> GetAllFeedbacksAsync();
    }
}


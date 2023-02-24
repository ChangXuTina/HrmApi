using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Entity;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.Infrastructure.Service
{
    public class InterviewStatusServiceAsync : IInterviewStatusServiceAsync
    {
        private readonly IInterviewStatusRepositoryAsync interviewStatusRepositoryAsync;

        public InterviewStatusServiceAsync(IInterviewStatusRepositoryAsync _interviewStatusRepositoryAsync)
        {
            interviewStatusRepositoryAsync = _interviewStatusRepositoryAsync;
        }

        public Task<int> AddInterviewStatusAsync(InterviewStatusRequestModel model)
        {
            InterviewStatus interviewStatus = new InterviewStatus()
            {
                Title = model.Title,
                IsActive = model.IsActive
            };
            return interviewStatusRepositoryAsync.InsertAsync(interviewStatus);

        }

        public Task<int> DeleteInterviewStatusAsync(int id)
        {
            return interviewStatusRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewStatusResponseModel>> GetAllInterviewStatusAsync()
        {
            var result = await interviewStatusRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new InterviewStatusResponseModel()
                { Id = x.Id, Title = x.Title, IsActive = x.IsActive });
            }
            return null;
        }

        public async Task<InterviewStatusResponseModel> GetInterviewStatusByIdAsync(int id)
        {
            var result = await interviewStatusRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new InterviewStatusResponseModel()
                {
                    Id = result.Id,
                    Title = result.Title,
                    IsActive = result.IsActive
                };
            }
            return null;

        }

        public Task<int> UpdateInterviewStatusAsync(InterviewStatusRequestModel model)
        {
            InterviewStatus interviewStatus = new InterviewStatus()
            {
                Id = model.Id,
                Title = model.Title,
                IsActive = model.IsActive
            };
            return interviewStatusRepositoryAsync.UpdateAsync(interviewStatus);

        }
    }
}


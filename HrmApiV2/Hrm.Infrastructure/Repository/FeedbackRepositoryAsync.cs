using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class FeedbackRepositoryAsync : BaseRepositoryAsync<Feedback>, IFeedbackRepositoryAsync
    {
        public FeedbackRepositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


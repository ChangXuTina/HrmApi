using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class InterviewStatusRepositoryAsync : BaseRepositoryAsync<InterviewStatus>, IInterviewStatusRepositoryAsync
    {
        public InterviewStatusRepositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


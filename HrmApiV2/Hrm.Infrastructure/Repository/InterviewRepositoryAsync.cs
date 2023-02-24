using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class InterviewRepositoryAsync : BaseRepositoryAsync<Interview>, IInterviewRepositoryAsync
    {
        public InterviewRepositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class SubmissionRepositoryAsync : BaseRepositoryAsync<Submission>, ISubmissionRepositoryAsync
    {
        public SubmissionRepositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


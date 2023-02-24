using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class JobCategoryRepositoryAsync : BaseRepositoryAsync<JobCategory>, IJobCategoryRepositoryAsync
    {
        public JobCategoryRepositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


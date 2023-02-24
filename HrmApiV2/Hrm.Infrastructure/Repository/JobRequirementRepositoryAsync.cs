using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class JobRequirementRepositoryAsync : BaseRepositoryAsync<JobRequirement>, IJobRequirementRepositoryAsync
    {
        public JobRequirementRepositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


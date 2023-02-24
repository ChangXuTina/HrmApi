using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class CandidateRespositoryAsync : BaseRepositoryAsync<Candidate>, ICandidateRepositoryAsync
    {
        public CandidateRespositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


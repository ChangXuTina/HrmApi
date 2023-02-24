using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class EmployeeStatusRepositoryAsync : BaseRepositoryAsync<EmployeeStatus>, IEmployeeStatusRepositoryAsync
    {
        public EmployeeStatusRepositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


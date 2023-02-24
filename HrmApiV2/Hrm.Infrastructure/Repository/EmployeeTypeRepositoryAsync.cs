using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
    public class EmployeeTypeRepositoryAsync : BaseRepositoryAsync<EmployeeType>, IEmployeeTypeRepositoryAsync
    {
        public EmployeeTypeRepositoryAsync(HrmDbContext _context) : base(_context)
        {
        }
    }
}


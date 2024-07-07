using Microsoft.EntityFrameworkCore;
using CaseProcess.Core.Entities;

namespace CaseProcess.Infra.Context;

public class CompanyAreaRepository : ProcessDbRepository<CompanyArea>, ICompanyAreaRepository
{
    public CompanyAreaRepository(ProcessDbContext dbContext) : base(dbContext)
    {
    }
}
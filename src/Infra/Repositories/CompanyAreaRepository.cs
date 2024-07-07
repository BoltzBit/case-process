using CaseProcess.Core.Entities;
using CaseProcess.Infra.Context;

namespace CaseProcess.Infra.Repositories;

public class CompanyAreaRepository : ProcessDbRepository<CompanyArea>, ICompanyAreaRepository
{
    public CompanyAreaRepository(ProcessDbContext dbContext) : base(dbContext)
    {
    }
}
using CaseProcess.Core.Entities;
using CaseProcess.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace CaseProcess.Infra.Repositories;

public class CompanyAreaRepository : ProcessDbRepository<CompanyArea>, ICompanyAreaRepository
{
    public CompanyAreaRepository(ProcessDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<CompanyArea?> GetByNameAndDescriptionAsync(string name, string description)
    {
        return await Table
            .FirstOrDefaultAsync(c => name.Contains(c.Name) &&
                description.Contains(c.Description));
    }
}
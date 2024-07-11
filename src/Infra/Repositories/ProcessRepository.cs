using System.Collections;
using CaseProcess.Core.Entities;
using CaseProcess.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace CaseProcess.Infra.Repositories;

public class ProcessRepository : ProcessDbRepository<Process>, IProcessRepository
{
    public ProcessRepository(ProcessDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Process>> GetByParentId(int parentId)
    {
        return await Table
            .Where(p => p.ParentId == parentId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Process>> GetAllWithIncludes()
    {
        return await Table
            .Include(p => p.SubProcesses)
            .ToListAsync();
    }

    public async Task<Process?> GetByNameAndDescription(string name, string description)
    {
        return await Table
            .FirstOrDefaultAsync(p => name.Contains(p.Name) &&
                description.Contains(p.Description));
    }
}
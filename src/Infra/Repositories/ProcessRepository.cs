using CaseProcess.Core.Entities;
using CaseProcess.Infra.Context;

namespace CaseProcess.Infra.Repositories;

public class ProcessRepository : ProcessDbRepository<Process>, IProcessRepository
{
    public ProcessRepository(ProcessDbContext dbContext) : base(dbContext)
    {
    }
}
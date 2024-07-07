using CaseProcess.Core.Entities;

namespace CaseProcess.Infra.Context;

public class ProcessRepository : ProcessDbRepository<Process>, IProcessRepository
{
    public ProcessRepository(ProcessDbContext dbContext) : base(dbContext)
    {
    }
}
using CaseProcess.Core.Entities;
using CaseProcess.Infra.Context;

namespace CaseProcess.Infra.Repositories;

public interface IProcessRepository : IProcessDbRepository<Process>
{
    Task<IEnumerable<Process>> GetByParentId(int parentId);
    Task<IEnumerable<Process>> GetAllWithIncludes();
    Task<Process?> GetByNameAndDescription(string name, string description);
}
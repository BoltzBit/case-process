using CaseProcess.Core.Entities;
using CaseProcess.Infra.Context;

namespace CaseProcess.Infra.Repositories;

public interface ICompanyAreaRepository : IProcessDbRepository<CompanyArea>
{
    Task<IEnumerable<CompanyArea>> GetAllWithIncludeAsync();
    Task<CompanyArea?> GetByNameAndDescriptionAsync(string name, string description);
}
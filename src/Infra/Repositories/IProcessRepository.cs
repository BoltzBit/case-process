using CaseProcess.Core.Entities;
using CaseProcess.Infra.Context;

namespace CaseProcess.Infra.Repositories;

public interface IProcessRepository : IProcessDbRepository<Process>
{
}
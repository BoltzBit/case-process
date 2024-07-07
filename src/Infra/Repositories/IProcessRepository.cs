using CaseProcess.Core.Entities;

namespace CaseProcess.Infra.Context;

public interface IProcessRepository : IProcessDbRepository<Process>
{
}
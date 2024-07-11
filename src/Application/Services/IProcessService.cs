using CaseProcess.Application.Features.Commands;

namespace CaseProcess.Application.Services;

public interface IProcessService
{
    Task InsertAsync(CreateProcessCommand command);
}

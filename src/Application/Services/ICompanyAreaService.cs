using CaseProcess.Application.Features.Commands;

namespace CaseProcess.Application.Services;

public interface ICompanyAreaService
{
    Task InsertAsync(CreateCompanyAreaCommand command);
}

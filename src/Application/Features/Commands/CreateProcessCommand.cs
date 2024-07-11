using CaseProcess.Application.Services;
using MediatR;

namespace CaseProcess.Application.Features.Commands;

public class CreateProcessCommand : IRequest<bool>
{
    public required int CompanyAreaId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public int? ParentId { get; set; }
}

public class CreateProcessCommandHandler : IRequestHandler<CreateProcessCommand, bool>
{
    private readonly IProcessService _processService;

    public CreateProcessCommandHandler(
        IProcessService processService)
    {
        _processService = processService;
    }

    public async Task<bool> Handle(
        CreateProcessCommand request,
        CancellationToken cancellationToken)
    {
        await _processService.InsertAsync(request);

        return true;
    }
}
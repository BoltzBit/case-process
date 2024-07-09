using CaseProcess.Application.Services;
using MediatR;

namespace CaseProcess.Application.Features.Commands;

public class CreateCompanyAreaCommand : IRequest<bool>
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}

public class CreateCompanyAreaCommandHandler : IRequestHandler<CreateCompanyAreaCommand, bool>
{
    private readonly ICompanyAreaService _companyAreaService;

    public CreateCompanyAreaCommandHandler(
        ICompanyAreaService companyAreaService)
    {
        _companyAreaService = companyAreaService;
    }

    public async Task<bool> Handle(
        CreateCompanyAreaCommand request,
        CancellationToken cancellationToken)
    {
        await _companyAreaService.InsertAsync(request);

        return true;
    }
}
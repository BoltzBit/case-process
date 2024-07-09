using MediatR;

namespace CaseProcess.Application.Features.Commands;

public class CreateCompanyAreaCommand : IRequest<bool>
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}

public class CreateCompanyAreaCommandHandler : IRequestHandler<CreateCompanyAreaCommand, bool>
{
    public async Task<bool> Handle(
        CreateCompanyAreaCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
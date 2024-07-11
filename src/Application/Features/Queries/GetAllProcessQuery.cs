using AutoMapper;
using CaseProcess.Core.Models;
using CaseProcess.Infra.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CaseProcess.Application.Features.Queries;

public class GetAllProcessQuery : IRequest<IEnumerable<ProcessModel>>
{
}

public class GetAllProcessQueryHandler :
    IRequestHandler<GetAllProcessQuery, IEnumerable<ProcessModel>>
{
    private readonly IProcessRepository _processRepository;
    private readonly IMapper _mapper;

    public GetAllProcessQueryHandler(
        IProcessRepository processRepository,
        IMapper mapper)
    {
        _processRepository = processRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProcessModel>> Handle(
        GetAllProcessQuery request, 
        CancellationToken cancellationToken)
    {
        var processes = await _processRepository
            .GetAllWithIncludes();

        if(!processes.Any())
        {
            return Enumerable.Empty<ProcessModel>();
        }

        return _mapper.Map<IEnumerable<ProcessModel>>(processes);
    }
}

using AutoMapper;
using CaseProcess.Core.Models;
using CaseProcess.Infra.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CaseProcess.Application.Features.Queries;

public class GetAllCompanyAreaQuery : IRequest<IEnumerable<CompanyAreaModel>>
{

}

public class GetAllCompanyAreaQueryHandler :
    IRequestHandler<GetAllCompanyAreaQuery, IEnumerable<CompanyAreaModel>>
{
    private readonly ICompanyAreaRepository _companyAreaRepository;
    private readonly IMapper _mapper;

    public GetAllCompanyAreaQueryHandler(
        ICompanyAreaRepository companyAreaRepository,
        IMapper mapper)
    {
        _companyAreaRepository = companyAreaRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CompanyAreaModel>> Handle(
        GetAllCompanyAreaQuery request, 
        CancellationToken cancellationToken)
    {
        var companyAreas = await _companyAreaRepository
            .GetAll()
            .ToListAsync(cancellationToken);

        if(companyAreas.Count == 0)
        {
            return Enumerable.Empty<CompanyAreaModel>();
        }

        return _mapper.Map<IEnumerable<CompanyAreaModel>>(companyAreas);
    }
}

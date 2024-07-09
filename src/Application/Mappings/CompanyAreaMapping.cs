using AutoMapper;
using CaseProcess.Application.Features.Commands;
using CaseProcess.Core.Entities;

namespace CaseProcess.Application.Mappings;

public class CompanyAreaMapping : Profile
{
    public CompanyAreaMapping() 
    {
        CreateMap<CreateCompanyAreaCommand, CompanyArea>();
    }
}
using AutoMapper;
using CaseProcess.Application.Features.Commands;
using CaseProcess.Core.Entities;
using CaseProcess.Core.Models;

namespace CaseProcess.Application.Mappings;

public class CompanyAreaMapping : Profile
{
    public CompanyAreaMapping() 
    {
        CreateMap<CreateCompanyAreaCommand, CompanyArea>();
        CreateMap<CompanyAreaModel, CompanyArea>()
            .ReverseMap();
    }
}
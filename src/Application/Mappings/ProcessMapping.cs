using AutoMapper;
using CaseProcess.Application.Features.Commands;
using CaseProcess.Core.Entities;
using CaseProcess.Core.Models;

namespace CaseProcess.Application.Mappings;

public class ProcessMapping : Profile
{
    public ProcessMapping() 
    {
        CreateMap<CreateProcessCommand, Process>();
        CreateMap<ProcessModel, Process>()
            .ReverseMap();
    }
}
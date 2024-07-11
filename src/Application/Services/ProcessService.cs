using CaseProcess.Application.Features.Commands;
using CaseProcess.Core.Entities;
using CaseProcess.Infra.Repositories;

namespace CaseProcess.Application.Services;

public class ProcessService : IProcessService
{
    private readonly IProcessRepository _processRepository;

    public ProcessService(IProcessRepository processRepository)
    {
        _processRepository = processRepository;
    }

    public async Task InsertAsync(CreateProcessCommand command)
    {
        var process = await _processRepository
            .GetByNameAndDescription(command.Name, command.Description);
        
        if(process is not null)
        {
            throw new Exception(
                $"Already Exist the process with the same Name: {command.Name} and Description: {command.Description}!");
        }

        process = new Process(
            command.CompanyAreaId,
            command.Name, 
            command.Description,
            command.ParentId);

        await _processRepository.InsertAsync(process);
    }
}

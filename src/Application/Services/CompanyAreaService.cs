using CaseProcess.Application.Features.Commands;
using CaseProcess.Core.Entities;
using CaseProcess.Infra.Repositories;

namespace CaseProcess.Application.Services;

public class CompanyAreaService : ICompanyAreaService
{
    private readonly ICompanyAreaRepository _companyAreaRepository;

    public CompanyAreaService(ICompanyAreaRepository companyAreaRepository)
    {
        _companyAreaRepository = companyAreaRepository;
    }

    public async Task InsertAsync(CreateCompanyAreaCommand command)
    {
        var companyArea = await _companyAreaRepository
            .GetByNameAndDescriptionAsync(command.Name, command.Description);
        
        if(companyArea is not null)
        {
            throw new Exception(
                $"Already Exist the company area with the same Name: {command.Name} and Description: {command.Description}!");
        }

        companyArea = new CompanyArea(
            command.Name, 
            command.Description);

        await _companyAreaRepository.InsertAsync(companyArea);
    }
}

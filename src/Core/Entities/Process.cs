using CaseProcess.Core.DomainObjects;

namespace CaseProcess.Core.Entities;

public class Process : BaseEntity
{
    public int CompanyAreaId { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public bool IsActive { get; private set; }
    public int? ParentId { get; private set; }
    public CompanyArea? CompanyArea { get; private set; }
    public Process? Parent { get; private set; }
    public IEnumerable<Process> SubProcesses { get; private set; } = new List<Process>();

    public Process(
        int companyAreaId,
        string name,  
        string description,
        int? parentId,
        bool isAactive = true)
    {
        Validations
            .SizeValidation(
                name, 
                Constants.FIELD_MAX_LENGTH_NAME, 
                $"The name of Process must be less then {Constants.FIELD_MAX_LENGTH_NAME}");

        Validations
            .SizeValidation(
                description, 
                Constants.FIELD_MAX_LENGTH_DESCRIPTION, 
                $"The description of Process must be less then {Constants.FIELD_MAX_LENGTH_DESCRIPTION}");
                
        CompanyAreaId = companyAreaId;
        Name = name;
        Description = description;
        IsActive = isAactive;
        ParentId = parentId ?? null;
    }

    public void UpdateName(string name)
    {
        Validations.SizeValidation(name, 50, $"The name of Process must be less then {50}");
        Name = name;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    protected Process()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
    }
}
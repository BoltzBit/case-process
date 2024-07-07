using CaseProcess.Core.DomainObjects;

namespace CaseProcess.Core.Entities;

public class Process : BaseEntity
{
    public string Name { get; private set; }
    public bool IsActive { get; private set; }
    public int? ParentId { get; private set; }
    public IEnumerable<Process> SubProcesses { get; set; } = [];

    public Process(
        string name,  
        int? parentId,
        bool isAactive = true)
    {
        Validations
            .SizeValidation(
                name, 
                Constants.FIELD_MAX_LENGTH_NAME, 
                $"The name of Process must be less then {Constants.FIELD_MAX_LENGTH_NAME}");

        Name = name;
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
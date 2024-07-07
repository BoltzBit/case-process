using CaseProcess.Core.DomainObjects;

namespace CaseProcess.Core.Entities;

public class CompanyArea : BaseEntity
{
    public string Name { get; private set; }
    public bool IsActive { get; private set; }
    public IEnumerable<Process> Processes { get; set; } = [];

    public CompanyArea(
        string name,
        bool isActive = true)
    {
        Validations
            .SizeValidation(
                name, 
                Constants.FIELD_MAX_LENGTH_NAME,
                $"The name of Process must be less then {Constants.FIELD_MAX_LENGTH_NAME}");

        Name = name;
        IsActive = isActive;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    protected CompanyArea(){}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
}
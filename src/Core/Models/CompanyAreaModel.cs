namespace CaseProcess.Core.Models;

public class CompanyAreaModel
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<ProcessModel> Processes { get; set; } = [];

}
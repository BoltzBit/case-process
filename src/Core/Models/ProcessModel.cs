using System.Diagnostics;

namespace CaseProcess.Core.Models;

public class ProcessModel
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool IsActive { get; set; }
    public int? ParentId { get; set; }
    public IEnumerable<ProcessModel> SubProcesses { get; set; } = [];
}
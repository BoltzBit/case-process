public class Process : BaseEntity
{
    private string Name { get; set; }

    public Process(string name)
    {
        Name = name;
    }
}
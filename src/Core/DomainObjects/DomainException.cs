namespace Process.Core.DomainObjects;

public class DomainException(string message) : Exception(message)
{
}
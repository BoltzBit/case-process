namespace CaseProcess.Core.DomainObjects;

public class DomainException(string message) : Exception(message)
{
}
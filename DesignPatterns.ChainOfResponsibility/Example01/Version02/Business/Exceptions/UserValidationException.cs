namespace DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Exceptions;

public class UserValidationException : Exception
{
    public UserValidationException(string message) : base(message)
    {
    }
}
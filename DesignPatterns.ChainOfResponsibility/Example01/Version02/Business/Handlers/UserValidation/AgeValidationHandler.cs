using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Exceptions;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Handlers.UserValidation;

public class AgeValidationHandler : Handler<User>
{
    public override void Handle(User user)
    {
        if (user.Age < 18) throw new UserValidationException("You have to be 18 years or older");

        base.Handle(user);
    }
}
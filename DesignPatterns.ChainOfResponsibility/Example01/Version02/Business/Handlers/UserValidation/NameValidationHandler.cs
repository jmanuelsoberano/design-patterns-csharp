using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Exceptions;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Handlers.UserValidation;

public class NameValidationHandler : Handler<User>
{
    public override void Handle(User user)
    {
        if (user.Name.Length <= 1) throw new UserValidationException("Your name is unlikely this short.");

        base.Handle(user);
    }
}
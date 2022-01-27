using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Exceptions;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Handlers.UserValidation;

public class CitizenshipRegionValidationHandler : Handler<User>
{
    public override void Handle(User user)
    {
        if (user.CitizenshipRegion.TwoLetterISORegionName == "NO")
            throw new UserValidationException("We currently do not support Norwegians");

        base.Handle(user);
    }
}
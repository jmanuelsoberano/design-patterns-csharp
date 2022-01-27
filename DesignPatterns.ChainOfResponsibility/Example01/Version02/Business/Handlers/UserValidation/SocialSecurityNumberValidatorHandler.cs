using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Exceptions;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Models;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Validators;

namespace DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Handlers.UserValidation;

public class SocialSecurityNumberValidatorHandler : Handler<User>
{
    private SocialSecurityNumberValidator socialSecurityNumberValidator
        = new SocialSecurityNumberValidator();

    public override void Handle(User request)
    {
        if (!socialSecurityNumberValidator.Validate(request.SocialSecurityNumber,
                request.CitizenshipRegion))
            throw new UserValidationException("Social security number could not be validated");
        base.Handle(request);
    }
}
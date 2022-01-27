using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Exceptions;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Handlers.UserValidation;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Models;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Validators;

namespace DesignPatterns.ChainOfResponsibility.Example01.Version02.Business;

public class UserProcessor
{
    private SocialSecurityNumberValidator socialSecurityNumberValidator = new();

    public bool Register(User user)
    {
        try
        {
            var handler = new SocialSecurityNumberValidatorHandler();

            handler.SetNext(new AgeValidationHandler())
                .SetNext(new NameValidationHandler())
                .SetNext(new CitizenshipRegionValidationHandler());

            handler.Handle(user);
        }
        catch (UserValidationException ex)
        {
            return false;
        }

        return true;
    }
}
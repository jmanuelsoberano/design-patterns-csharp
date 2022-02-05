namespace DesignPatterns.Facade.Example02.Version02.Business.Entities;

public class State
{
    public State GetStateForZipCode(string zipCode)
    {
        // service or db lookup would go here
        return new State();
    }

    public string Name => "Washington";
}
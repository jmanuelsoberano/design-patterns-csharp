namespace DesignPatterns.Facade.Example01.Version01.Business;

public class BigClass
{
    private int _i;

    public int GetValueA()
    {
        // some work
        return _i;
    }

    public string GetValueB()
    {
        return "Ball of Mud";
    }

    public void SetValueI(int i)
    {
        _i = i;
    }

    public void IncrementI()
    {
        _i++;
    }

    public void DoSomething()
    {
        _i--;
    }

    public int AddToI(int addMe)
    {
        _i += addMe;
        return _i;
    }

    public void UnrelatedMethod()
    {
        // do something unrelated
    }

    public void AddedThisMethodLater()
    {
        // calls a db for a number

        var theNumber = 12;
        _i += theNumber;
    }

    public void DecrememntI()
    {
        _i--;
    }
}
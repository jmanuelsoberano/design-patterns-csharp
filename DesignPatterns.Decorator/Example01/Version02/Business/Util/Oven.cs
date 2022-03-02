namespace DesignPatterns.Decorator.Example01.Version02.Business.Util;

public class Oven
{
    private static readonly int REQUIRED_WAITING_TIME_TO_USE_OVEN = 2;

    private static Oven _oven;

    private DateTime lastTimeUsage;

    public static Oven GetInstance()
    {
        if (_oven == null) _oven = new Oven();
        return _oven;
    }

    private Oven()
    {
        lastTimeUsage = new DateTime();
    }

    public void SetLastTimeUsage(DateTime date)
    {
        Console.WriteLine("         Setting last time usage: " + date);
        lastTimeUsage = date;
    }

    public bool IsReady()
    {
        var clock = new Clock();
        var currentDate = clock.GetCurrentDate();
        Console.WriteLine("      Checking if oven is ready");
        Console.WriteLine("         Current date: " + currentDate);
        Console.WriteLine("         Last time usage: " + lastTimeUsage);
        return clock.CalculateMinutesBetweenDates(currentDate,
            lastTimeUsage) > REQUIRED_WAITING_TIME_TO_USE_OVEN;
    }
}
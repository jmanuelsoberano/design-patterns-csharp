namespace DesignPatterns.Decorator.Example01.Version02.Business.Util;

public class Clock
{
    public DateTime GetCurrentDate()
    {
        var currentDate = new DateTime();
        return currentDate;
    }

    public long CalculateMinutesBetweenDates(DateTime date1, DateTime date2)
    {
        var minutes = (date1.TimeOfDay - date2.TimeOfDay).Ticks / 60000;
        return Math.Abs(minutes);
    }

    public void SetAlarmDelay(int delay)
    {
        Thread.Sleep(2000);
    }
}
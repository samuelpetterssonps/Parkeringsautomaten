namespace Parkeringsautomaten.Lib;

public static class Cost
{
    public static int Calculate(int duration, DayOfWeek day)
    {
        var cost = MathF.Ceiling(((float)duration - 15) / 10) * 5;
        
        if (day is DayOfWeek.Saturday or DayOfWeek.Sunday)
        {
            cost /= 2;
        }

        if (cost > 150)
        {
            cost = 150;
        } else if (cost < 0)
        {
            cost = 0;
        }
        
        return (int)cost;
    }
}
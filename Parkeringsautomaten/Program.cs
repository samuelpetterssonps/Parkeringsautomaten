namespace Parkeringsautomaten;

public static class Program
{
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    
    public static int CalculateCost(int duration, Day day)
    {
        var cost = MathF.Ceiling(((float)duration - 15) / 10) * 5;
        
        if (day is Day.Saturday or Day.Sunday)
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

    private static Day StringToDay(string str)
    {
        switch (str.ToLower())
        {
            case "måndag" or "monday": return Day.Monday;
            case "tisdag" or "tuesday": return Day.Tuesday;
            case "onsdag" or "wednesday": return Day.Wednesday;
            case "torsdag" or "thursday": return Day.Thursday;
            case "fredag" or "friday": return Day.Friday;
            case "lördag" or "saturday": return Day.Saturday;
            case "söndag" or "sunday": return Day.Sunday;
            default: return Day.Monday;
        }
    }
    
    private static void Main(string[] args)
    {
        Console.Clear();
        
        while (true)
        {
            Console.WriteLine("Hur många minuter vill du parkera här?");
            var res = int.TryParse(Console.ReadLine(), out var duration);

            if (!res)
            {
                var defaultColor = Console.ForegroundColor;
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vänligen ange ett giltigt nummer!");
                Console.ForegroundColor = defaultColor;
                
                continue;
            }
                
            Console.WriteLine("Och vilken veckodag är det?");
            var day = StringToDay(Console.ReadLine()!);
            
            var cost = CalculateCost(duration, day);

            Console.WriteLine($"Kostnad: {cost}\n");
        }
    }
}
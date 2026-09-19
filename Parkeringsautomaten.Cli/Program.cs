namespace Parkeringsautomaten.Cli;

public static class Program
{
    private static DayOfWeek StringToDay(string str)
    {
        switch (str.ToLower())
        {
            case "måndag" or "monday": return DayOfWeek.Monday;
            case "tisdag" or "tuesday": return DayOfWeek.Tuesday;
            case "onsdag" or "wednesday": return DayOfWeek.Wednesday;
            case "torsdag" or "thursday": return DayOfWeek.Thursday;
            case "fredag" or "friday": return DayOfWeek.Friday;
            case "lördag" or "saturday": return DayOfWeek.Saturday;
            case "söndag" or "sunday": return DayOfWeek.Sunday;
            default: return DayOfWeek.Monday;
        }
    }
    
    private static void Main()
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
                
                break;
            }
                
            Console.WriteLine("Och vilken veckodag är det?");
            var day = StringToDay(Console.ReadLine()!);
            
            var cost = Lib.Cost.Calculate(duration, day);

            Console.WriteLine($"Kostnad: {cost}\n");
        }
    }
}
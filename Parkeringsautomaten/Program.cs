namespace Parkeringsautomaten;

public static class Program
{
    public static int CalculateCost(int duration, string day)
    {
        var cost = MathF.Ceiling(((float)duration - 15) / 10) * 5;
        
        if (day is "lördag" or "söndag")
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
            var day = Console.ReadLine()!.ToLower();

            if (day == "")
            {
                var defaultColor = Console.ForegroundColor;
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vänligen ange en giltig veckodag!");
                Console.ForegroundColor = defaultColor;
                
                continue;
            }

            var cost = CalculateCost(duration, day);

            Console.WriteLine($"Kostnad: {cost}\n");
        }
    }
}
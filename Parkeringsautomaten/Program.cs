namespace Parkeringsautomaten;

class Program
{
    private static int CalculateCost(int time, string day)
    {
        float cost = 0;

        cost = MathF.Ceiling(((float)time - 15) / 10) * 5;

        if (day == "lördag" || day == "söndag")
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
    
    static void Main(string[] args)
    {
        Console.Clear();
        
        while (true)
        {
            Console.WriteLine("Hur många minuter vill du parkera här?");
            var res = int.TryParse(Console.ReadLine(), out var time);

            if (!res)
            {
                var defaultColor = Console.ForegroundColor;
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vänligen ange ett giltigt nummer!");
                Console.ForegroundColor = defaultColor;
                
                continue;
            }
                
            Console.WriteLine("Och vilken veckodag är det?");
            var day = Console.ReadLine().ToLower();

            var cost = CalculateCost(time, day);

            Console.WriteLine($"Kostnad: {cost}\n");
        }
    }
}
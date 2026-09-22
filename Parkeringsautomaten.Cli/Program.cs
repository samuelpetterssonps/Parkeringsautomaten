namespace Parkeringsautomaten.Cli;

public static class Program
{
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
            var day = Lib.DayOfWeekParser.FromString(Console.ReadLine()!);

            var cost = Lib.Cost.Calculate(duration, day);

            Console.WriteLine($"Kostnad: {cost}\n");
        }
    }
}
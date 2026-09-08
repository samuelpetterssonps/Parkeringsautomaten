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
            int tid;
            int.TryParse(Console.ReadLine(), out tid);
                
            Console.WriteLine("Och vilken veckodag är det?");
            string veckodag = Console.ReadLine().ToLower();

            int kostnad = CalculateCost(tid, veckodag);

            Console.WriteLine($"Kostnad: {kostnad}\n");
        }
    }
}
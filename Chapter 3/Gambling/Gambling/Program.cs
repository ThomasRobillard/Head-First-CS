using Test;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Random random = new Random();
        double odds = .75;
        Guy player = new Guy() { Cash = 100, Name = "The player" };

        Console.WriteLine("Welcome to the Golden Grin Casino. The odds are " + odds);

        while (true)
        {
            player.WriteMyInfo();

            Console.WriteLine("How much do you want to bet: ");
            string howMuch = Console.ReadLine();

            if (int.TryParse(howMuch, out int amount))
            {
                int pot = amount * 2;
                if (random.NextDouble() > odds)
                {
                    Console.WriteLine("You win " + pot + " dollars!");
                    player.Cash += pot;
                }
                else
                {
                    Console.WriteLine("Bad luck, you lose.");
                    player.Cash -= pot/2;
                }
            }
            if (player.Cash <= 0)
            {
                Console.WriteLine("The house always wins.");
                break;
            }
        }
    }
}
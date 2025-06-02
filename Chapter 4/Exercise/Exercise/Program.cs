using Exercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant swap;

        Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap. q to quit");
        while (true)
        {
            char keyChar = Console.ReadKey(true).KeyChar;

            if (keyChar == '1')
            {
                Console.WriteLine("You pressed 1");
                Console.WriteLine("Calling lloyd.WhoAmI()");
                lloyd.WhoAmI();
            }
            else if (keyChar == '2')
            {
                Console.WriteLine("You pressed 2");
                Console.WriteLine("Calling lucinda.WhoAmI()");
                lucinda.WhoAmI();
            }
            else if (keyChar == '3')
            {
                Console.WriteLine("You pressed 3");
                swap = lucinda;
                lucinda = lloyd;
                lloyd = swap;
                Console.WriteLine("References have been swapped");
            }
            else if (keyChar == '4')
            {
                lucinda.SpeakTo(lloyd, "Hi, Lloyd");
            }
            else if ((keyChar == 'q') || (keyChar == 'Q'))
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap. q to quit");
            }
        }
    }
}

namespace AbilityScoreTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }

        /// <summary>
        /// Writes a prompt and reads a double value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse.</returns>
        /// <exception cref="NotImplementedException"></exception>
        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.WriteLine(prompt + " [" + lastUsedValue + "]: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double result))
            {
                Console.WriteLine("    using value " + result);
                return result;
            }
            else
            {
                Console.WriteLine("    using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
        /// <summary>
        /// Writes a prompt and reads an int value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse.</returns>
        /// <exception cref="NotImplementedException"></exception>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            // Write the prompt followed by [default value];
            Console.WriteLine(prompt + " [" +  lastUsedValue + "]: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine("    using value " + result);
                return result;
            }
            else
            {
                Console.WriteLine("    using default value " + lastUsedValue);
                return lastUsedValue;
            }  
        }
    }
}
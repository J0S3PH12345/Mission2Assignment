using Mission2Assignment;

internal class Program
{
    // Create a single Random instance for the entire class
    private static Random random = new Random();

    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the Dice Throwing Simulator!");
        System.Console.Write("How many dice rolls would you like to simulate? ");

        // Declare an integer variable to store the number of rolls
        int numberOfRolls = int.Parse(System.Console.ReadLine());

        // Pass the valid number of rolls to the TimesRolled method
        TimesRolled(numberOfRolls);
    }

    private static void TimesRolled(int numberOfRolls)
    {
        DiceStuff ds = new DiceStuff(random); // Pass random to DiceStuff class
        // Get roll results
        int[] rollResults = ds.RollDice(numberOfRolls);

        // Display results
        System.Console.WriteLine("\nDice Roll Simulation Results:");
        System.Console.WriteLine("\nEach \"*\" represents 1% of the total number of rolls");
        System.Console.WriteLine($"\nTotal number of rolls = {numberOfRolls}");

        // Loop through each possible sum (2 to 12)
        for (int i = 2; i <= 12; i++)
        {
            // Calculate the percentage for this sum
            int percentage = (int)Math.Round((rollResults[i] / (double)numberOfRolls) * 100);

            // Print the sum and display the corresponding number of asterisks
            System.Console.WriteLine($"{i}: {new string('*', percentage)}");
        }

        // Display the final message after the results
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}



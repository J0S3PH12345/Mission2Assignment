using System;

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
        // Get roll results
        int[] rollResults = RollDice(numberOfRolls);

        // Display results
        System.Console.WriteLine("\nDice Roll Simulation Results:");

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

    // A helper method to simulate rolling dice
    private static int[] RollDice(int numberOfRolls)
    {
        int[] rollResults = new int[13]; // Index 0 and 1 are unused; 2-12 will hold results

        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = random.Next(1, 7); // Roll first die (1-6)
            int die2 = random.Next(1, 7); // Roll second die (1-6)
            int sum = die1 + die2;        // Calculate the sum of the dice

            rollResults[sum]++;           // Increment the corresponding index
        }

        return rollResults;
    }
}



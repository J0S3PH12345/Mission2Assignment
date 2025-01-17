using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class DiceStuff
    {
        private Random _random;  // Instance variable for random

        // Constructor to receive the random object
        public DiceStuff(Random random)
        {
            _random = random;
        }

        // Method to simulate rolling dice
        public int[] RollDice(int numberOfRolls)
        {
            int[] rollResults = new int[13]; // Index 0 and 1 are unused; 2-12 will hold results

            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = _random.Next(1, 7); // Roll first die (1-6)
                int die2 = _random.Next(1, 7); // Roll second die (1-6)
                int sum = die1 + die2;        // Calculate the sum of the dice

                rollResults[sum]++;           // Increment the corresponding index
            }

            return rollResults;
        }
    }
}

using Mission2;
using System;

namespace Mission2
{
    public class DiceRoll
    {
        private int[] rollTotals = new int[13];
        private Random random = new Random();

        public void SimulateDiceRolls(int numberOfRolls)
        {
            int die1, die2, total;

            for (int i = 0; i < numberOfRolls; i++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;

                rollTotals[total]++;
            }
        }

        public void PrintHistogram()
        {
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");

            int totalRolls = rollTotals.Sum(); 

            for (int i = 2; i <= 12; i++)
            {
                int percentage = rollTotals[i] * 100 / totalRolls;
                string asterisks = new string('*', percentage);

                Console.WriteLine($"{i}: {asterisks} ({percentage}%)");
            }
        }
    }

    
}

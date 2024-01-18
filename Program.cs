using Mission2;
using System;

namespace Mission2
{
    public class Program
    {
        public static void Main()  
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls = int.Parse(Console.ReadLine());

            DiceRoll diceRoll = new DiceRoll();
            diceRoll.SimulateDiceRolls(numberOfRolls);
            diceRoll.PrintHistogram();

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

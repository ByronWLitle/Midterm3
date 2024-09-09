using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables to hold values
            int guess = 0; //User input
            int num = 75; //Number in which they have to guess
            //Repeats until guess is equal to number
            while (guess != num)
            {
                //Prompts user for guess
                Console.Write("Guess a number between 0-100: ");
                //Converts user input to integer variable and store in memory
                guess = Convert.ToInt32(Console.ReadLine());
                //If-else statement that gives certain outputs to help the user guess number
                if (guess > num)
                {
                    //Outputs "too high" if guess is higher than number
                    Console.WriteLine("Too high!");
                }
                else if (guess < num)
                {
                    //Outputs "too low" if guess is lower than number
                    Console.WriteLine("Too low!");
                }
            }
            //Outputs user that guess is correct
            Console.WriteLine("You got it!");
            //Pauses program to allow user to view before program ends
            Console.ReadLine();
        }
    }
}

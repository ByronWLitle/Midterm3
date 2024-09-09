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
            int guess = 0;
            int num = 75;
            while (guess != num)
            {
                Console.WriteLine("Guess a number");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > num)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess < num)
                {
                    Console.WriteLine("Too low!");
                }
            }
        }
    }
}

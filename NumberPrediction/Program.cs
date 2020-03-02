using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            int claim = 10;
            int count = 0;
            int reserved = (new Random()).Next(1, 50);
            int number;

            while (claim > 0)
            {
                count++;
                Console.WriteLine("Enter a number: ");
                number = int.Parse(Console.ReadLine());

                if (reserved == number)
                {
                    Console.WriteLine($"Congratulations, you have won within {count} times.");
                    break;
                }

                if (reserved > number)
                    Console.WriteLine("Up");

                if (reserved < number)
                    Console.WriteLine("Down");

                claim--;
                if (claim == 0)
                {
                    Console.WriteLine("Game over. You have no claim.");
                    break;
                }
            }
        }
    }
}
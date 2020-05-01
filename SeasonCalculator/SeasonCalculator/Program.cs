using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number to know season name:");

            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Not a valid input. Enter integer number for month number");
            }
            else
            {
                if (number == 12 || number == 1 || number == 2)
                {
                    Console.WriteLine("Season is -> WINTER");
                }
                else if (number < 2 && number <= 5)
                {
                    Console.WriteLine("Season is -> SPRING");
                }
                else if (number < 5 && number <= 8)
                {
                    Console.WriteLine("Season is -> SUMMER");
                }
                else if (number < 8 && number <= 11)
                {
                    Console.WriteLine("Season is -> AUTUMN");
                }
                else
                {
                    Console.WriteLine("Inavlid Input !!!");
                }
            }
        }
    }
}

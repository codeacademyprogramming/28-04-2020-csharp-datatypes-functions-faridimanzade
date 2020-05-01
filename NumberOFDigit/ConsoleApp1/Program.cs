using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number to know find number of digits");

            int number;
    
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Not a valid input. Enter integer number");
                
            }
            else
            {
                Console.WriteLine(CalculateDigits(number));
            }

        }

        static int CalculateDigits(int number)
        {
            int counter = 0;
            while(number > 0)
            {
                number /= 10;
                counter++;
            }
            return counter;
        }
    }
}

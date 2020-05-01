using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNotPrime
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Integer number to know it is prime or not:");

            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Not a valid input, enter integer Number");
            }
            else
            {
                if (number == 1)
                {
                    Console.WriteLine("1 is neither prime, nor not prime");
                }
                else
                {
                    if (IsPrime(number) == true)
                    {
                        Console.WriteLine("Number is Prime");
                    }
                    else
                    {
                        Console.WriteLine("Number is not Prime");
                    }
                }
            }
        }

        static bool IsPrime(int number)
        {
            bool flag = true;

            for(int i = 2; i < number/2; i++)
            {
                if(number%i == 0)
                {
                    flag = false;
                    break;
                }
            }

            return flag;
            
        }
    }
}

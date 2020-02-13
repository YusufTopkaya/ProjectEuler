using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the largest prime factor of the number 600851475143?
            long number = 600851475143;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0 && isPrime(i))
                    Console.WriteLine(i);
            }
        }

        public static bool isPrime(int number)
        {
            if (number == 1 || number == 2)
                return true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }


            return true;
        }
    }
}

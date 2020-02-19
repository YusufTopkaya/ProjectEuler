using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the 10001st prime number?
            int counter = 1;
            int i = 3;
            while (counter < 10001)
            {

                if (isPrime(i))
                    counter++;
                i++;
            }
            Console.Write(i - 1);
            Console.Read();




        }
        public static bool isPrime(int number)
        {


            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }


            return true;
        }
    }
}

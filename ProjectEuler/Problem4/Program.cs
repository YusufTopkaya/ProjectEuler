using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Find the largest palindrome made from the product of two 3-digit numbers.
            int highest = 0;
            long product;
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    product = i * j;
                    int n, reverse = 0, rem;
                    n = (int)product;
                    while (n != 0)
                    {
                        rem = n % 10;
                        reverse = reverse * 10 + rem;
                        n /= 10;
                    }
                    if (reverse == product && product>highest)
                        highest = (int)product;

                }
            }
            Console.WriteLine("Highest palindrome is " + highest);
            Console.Read();
        }

      
       

       
    }
}

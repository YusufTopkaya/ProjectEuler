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
                    if (isPalindrome(product))
                    {
                        Console.WriteLine("Palindrome: " + product+" is product of "+i+" and "+j);
                        if (product > highest)
                            highest = (int)product;
                    }
                        
                }
            }
            Console.WriteLine("Highest palindrome is " + highest);
            Console.Read();
        }

        public static bool isPalindrome(long number)
        {
            int basamak = number.ToString().Length;
            double half = Math.Floor((double)(basamak / 2));





            int left = int.Parse(number.ToString().Substring(0, (int)half));
            int divider = (int)Math.Pow(10, (long)half);
            long right = number % divider;

            int n, reverse = 0, rem;
            n = (int)right;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }


            if (left - reverse == 0)
                return true;

            return false;
        }

       
    }
}

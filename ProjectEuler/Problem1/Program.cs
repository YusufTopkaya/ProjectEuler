using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sum of all the multiples of 3 or 5 below 1000.

            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                sum += (i % 3 == 0 || i % 5 == 0) ? i : 0;
            }
            Console.Write(sum);
            Console.Read();


        }
    }
}

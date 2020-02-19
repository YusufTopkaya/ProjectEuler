using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            int sum =0;
            int limit = 100;
            int sqrToLimit = (50 * 101) * (50 * 101);
            for (int i = 1; i <= 100; i++)
            {
                sum += i * i;
            }
            Console.Write(sqrToLimit-sum);
            Console.Read();
        }
    }
}

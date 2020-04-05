using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        /*
            There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            Find the product abc.
         */
        static void Main(string[] args)
        {
            int a, b, c;
            for (int i = 1; i < 1001; i++)
            {
                a = i;
                for (int j = 1; j < 1001-a; j++)
                {
                    b = j;
                    c = 1000 - a - b;
                    if((a*a)+(b*b)==c*c)
                    Console.WriteLine("{0}+{1}+{2}={3}",a,b,c,(a+b+c));
                }
            }

            Console.Read();
        }
    }
}

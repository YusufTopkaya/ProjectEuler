using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even Fibonacci Numbers
            int sum = 0;
            Func<int, int> fib = null;
            fib = n => (n < 2) ? 1 : fib(n - 1) + fib(n - 2);
            for (int i = 1; i < 100; i++)
            {     
                if(fib(i) > 4000000)
                    break;
                if (fib(i) % 2 == 0)
                    sum += fib(i);
            }
            Console.WriteLine(sum);
            Console.Read();

        }
    }
}

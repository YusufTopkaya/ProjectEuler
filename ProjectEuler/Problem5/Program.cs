using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        static void Main(string[] args)
        {
            int limit=20;
            int lastSqr;
            int sqr=0;
            int number = 1;
            
            for (int i = 2; i <= limit; i++)
            {
                if (number%i!=0 && number%Math.Sqrt(i)!=0)
                {
                    sqr = i;
                    lastSqr = i;
                    while(sqr<=limit)
                    {
                        sqr *= sqr;
                        if (sqr <= limit)
                            lastSqr = sqr;
                    }
                    
                    number *= lastSqr;             
                }
            }
            Console.WriteLine(number);
            Console.Read();          
        }

        
    }
}

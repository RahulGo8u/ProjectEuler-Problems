using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /*
     Multiples of 3 and 5
    Problem 1 
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
    The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below 1000.
     */
    internal class Problem1
    {                
        internal static long GetMultiplesOf3or5(long limit)
        {            
            long sum = 0;
            for (long i = 3; i < limit; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}

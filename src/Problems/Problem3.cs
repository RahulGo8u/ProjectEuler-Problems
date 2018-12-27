using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /*
    Largest prime factor
    Problem 3 
    The prime factors of 13195 are 5, 7, 13 and 29.
    What is the largest prime factor of the number 600851475143 ?
     */
    class Problem3
    {                
        /*48
        48%2==0(24)
        48%3==0(16)
        48%4==0(12)
        48%6==0(8)
        48%8==0(6)
        48%12==0(4)
        48%16==0(3)*/
        //Check only that if factor is primenumber or not. This is very fast to test.
        internal static long LargestPrimeFactor(long number)
        {
            long i = 2, factor=1;
            while(true)
            {
                if (number % i == 0)
                {
                    factor = number / i;
                    if (IsPrimeNumber(factor))
                    {
                        return factor;
                    }
                }                
                i++;
            }            
        }
        private static bool IsPrimeNumber(long number)
        {
            long divisor = 2;
            for (long i = number / 2; i > 1; i+=0)
            {
                if (number % i == 0) return false;
                i = number / (++divisor);
            }
            return true;
        }
    }
}

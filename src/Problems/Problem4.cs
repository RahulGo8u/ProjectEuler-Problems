using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem4
    {
        //Iterate from highest value of digits and make its palindrome        
        //Condition 1: Computed palindrome should be less than the square of number
        //Condition 2: Check if palindrome is divided by number and divisor is within the upper limit
        //Result: Factors will be divisor and dividend
        internal static double LargestPalindromeProduct(int digits)
        {
            double upperLimit = Math.Pow(10, digits) - 1;
            double lowerLimit = Math.Pow(10, digits - 1) - 1;
            double palindrome = 0;
            for (double number = upperLimit; number > lowerLimit; number--)
            {
                palindrome = double.Parse(MakePalindrome(number.ToString()));
                for (double divisor = upperLimit; divisor > lowerLimit; divisor--)
                {
                    if (palindrome > divisor * divisor)
                    {
                        break;
                    }
                    if (palindrome % divisor == 0 && (palindrome / divisor) < upperLimit)
                    {
                        return palindrome;
                    }
                }
            }
            return palindrome;
        }

        private static string MakePalindrome(string number)
        {
            return number + new string(number.Reverse().ToArray());
        }
    }
}

using ProjectEuler.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Problem1.GetMultiplesOf3or5(1000));
            Console.WriteLine(Problem2.EvenFibonacciNumbers(4000000));
            Console.WriteLine(Problem3.LargestPrimeFactor(600851475143));
            Console.WriteLine(Problem4.LargestPalindromeProduct(3));
            Console.ReadLine();
        }
    }
}

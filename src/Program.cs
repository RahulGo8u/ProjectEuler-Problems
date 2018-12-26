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
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace _1._1_Fibonacci
{
    public class Math
    {
        // TODO: Implementiere Methode Fibonacci
        public static IEnumerable<int> Fibonacci(int value)
        {
            int prev = 0;
            int next = 1;
            int sum = 1;
            for (int i = 0; i < value; i++)
            {
                yield return sum;
                sum = prev + next;
                prev = next;
                next = sum;
                
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Math.Fibonacci(8))
            {
                Console.WriteLine("{0} ", i);
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace _1._3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 3, 5, 7, 9 };

            PrintArray(arr1);
            PrintArray(arr2);

            int result = 0;
            result += Sum(arr1);
            result += Sum(arr2);
            System.Console.WriteLine("Result: " + result);

            Console.ReadKey();
        }

        public static void PrintArray(int[] array)
        {
            System.Console.WriteLine("Array Length: " + array.Length);
            foreach (int i in array)
            {
                System.Console.WriteLine(i + " ");
                
            }
            System.Console.WriteLine();
        }

        public static int Sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }
    }
}

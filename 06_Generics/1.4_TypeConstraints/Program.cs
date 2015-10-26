using System;

namespace _1._4_TypeConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1
            Test<int> test = new Test<int>();
            int i = test.GetNewInstance();

            // Aufgabe 2
            MyClass<MyBetterClass> myClass = new MyClass<MyBetterClass>();
        }
    }
}

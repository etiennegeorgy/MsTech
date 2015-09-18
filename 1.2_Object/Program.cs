using System;

namespace _1._2_Object
{
    class Program
    {
        // TODO: public static string GetStringRepresentation ...

        static void Main(string[] args)
        {
            // TODO: Test mit int / Ausgabe auf Konsole
            // string s1 = GetStringRepresentation(123);
            // System.Console.WriteLine(s1);

            // TODO Test mit bool / Ausgabe auf Konsole

            // TODO Test mit System.Drawing.Point / Ausgabe auf Konsole

            // TODO Test mit Person (siehe unten) / Ausgabe auf Konsole 

            Console.ReadKey();
        }
    }

    public class Person
    {
        private string firstName;
        private string lastName;
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // TODO: public override string ToString ...
    }

}

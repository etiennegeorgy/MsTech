using System;

namespace _1._2_Object
{
    class Program
    {
        public static string GetStringRepresentation(Object obj)
        {
            return obj.ToString();
        }
        static void Main(string[] args)
        {
            string s1 = GetStringRepresentation(123);
            System.Console.WriteLine(s1);
          
            bool b = true;
            string s2 = GetStringRepresentation(b);
            System.Console.WriteLine(s2);

            System.Drawing.Point point = new System.Drawing.Point();
            string s3 = GetStringRepresentation(point);
            System.Console.WriteLine(s3);

            Person person = new Person("Max", "Muster");
            string s4 = GetStringRepresentation(person);
            System.Console.WriteLine(s4);

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

        public override string ToString()
        {
            return lastName + ", " + firstName;
        }
    }

}

using System;
using System.Collections.Generic;

namespace _2._2_QueryOperators
{
    static class Extensions
    {
        /****** HsrMultipleOf ******/

        // TODO: Operator 'HsrMultipleOf' implementieren / Gibt alle Werte zurück, bei denen "x % factor" == 0 ist

        /****** HsrWhere ******/
        
        // TODO: Operator 'HsrWhere' implementieren / Gibt alle Werte zurück, bei denen ein "Predicate<T>" true liefert

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 2, 9, 13, 8, 9, 0, -6, 12 };
            string[] cities = { "Bern", "Basel", "Zürich", "Rapperswil", "Genf" };



            /****** HsrMultipleOf ******/

            // Operator 'HsrMultipleOf' / Vielfaches von 4 auf 'numbers'
            Console.WriteLine("---------- \r\nOperator 'HsrMultipleOf' / Vielfaches von 4 auf 'numbers'");
            //IEnumerable<int> multiple4 = numbers.HsrMultipleOf(4);
            //foreach (int i in multiple4) { Console.WriteLine(i); }

            // Operator 'HsrMultipleOf' / Vielfaches von 2 und 3 auf 'numbers'
            Console.WriteLine("---------- \r\nOperator 'HsrMultipleOf' / Vielfaches von 2 und 3 auf 'numbers'");
            // TODO: Implementieren



            /****** HsrWhere ******/
            
            // Operator 'HsrWhere' / Städtenamen mit 'B' auf 'cities'
            Console.WriteLine("---------- \r\nOperator 'HsrWhere' / Städtenamen mit 'B' auf 'cities'");
            //IEnumerable<string> citiesB = cities.HsrWhere(delegate(string s) { return s.StartsWith("B"); });
            //foreach (string s in citiesB) { Console.WriteLine(s); }

            // Operator 'HsrWhere' / Städtenamen mit 'e' im Namen und Länge >= 5 auf 'cities'
            Console.WriteLine("---------- \r\nOperator 'HsrWhere' / Städtenamen mit 'e' im Namen und Länge >= 5 auf 'cities'");
            // TODO: Implementieren

           
            
            /****** HsrWhere / HsrMultipleOf ******/

            // Operator 'HsrWhere' & 'HsrMultipleOf' / Grösser oder gleich 5 und Vielfaches von 2 auf 'numbers'
            Console.WriteLine("---------- \r\nOperator 'HsrWhere' & 'HsrMultipleOf' / Grösser oder gleich 5 und Vielfaches von 2 auf 'numbers'");
            // TODO: Implementieren
            
            // Operator 'HsrWhere' / Grösser oder gleich 5 und Vielfaches von 2 auf 'numbers'
            Console.WriteLine("---------- \r\nOperator 'HsrWhere' / Grösser oder gleich 5 und Vielfaches von 2 auf 'numbers'");
            // TODO: Implementieren



            Console.ReadKey();
        }

       
       

        

    }
}

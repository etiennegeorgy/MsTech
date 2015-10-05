using System;

namespace _1._1_Shapes
{
    class Program
    {
        static void Main(string[] args)
        { 
            // TODO: Erzeuge Square-Objekt
            Square s = new Square(1, 2, 4);

            // TODO: Ausgabe Degrees
            System.Console.WriteLine(s.Degrees);
            
            // TODO: Ausgabe Area()
            System.Console.WriteLine(s.Area());

            // TODO: Ausgabe X1, Y1, X2, Y2
            System.Console.WriteLine(s.X1);
            System.Console.WriteLine(s.Y1);
            System.Console.WriteLine(s.X2);
            System.Console.WriteLine(s.Y2);

            Console.ReadKey();
        }
    }
}

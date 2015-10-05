using System;

namespace _1._4_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Compound c1 = new Compound("C1");
            c1.Add(new Kreis("K1"));

            Compound c2 = new Compound("C2");
            c2.Add(new Rechteck("R21"));
            c2.Add(new Kreis("K21"));
            c1.Add(c2);
            c1.Add(new Kreis("K2"));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Drawing... (dynamic binding)");
            Console.WriteLine("-------------------------------------------");
            c1.Draw();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            bool b = false;
            int? c = 10;
            bool? d = null;
            int? e = null;

            Console.WriteLine("Resultat c + a: {0} \nAusdruckstyp: {1}", (c + a), (c + a).GetType());
            //Console.WriteLine("Resultat a + null: {0} \nAusdruckstyp: {1}", (a + null), (a + null).GetType());
            Console.WriteLine("Resultat a < c: {0} \nAusdruckstyp: {1}", (a < c), (a < c).GetType());
            Console.WriteLine("Resultat a + null < c: {0} \nAusdruckstyp: {1}", (a + null < c), (a + null < c).GetType());
            Console.WriteLine("Resultat a > null: {0} \nAusdruckstyp: {1}", (a > null), (a > null).GetType());
            //Console.WriteLine("Resultat d: {0} \nAusdruckstyp: {1}", d, d.GetType());
            //Console.WriteLine("Resultat (a + c - e) * 9898 + 1000: {0} \nAusdruckstyp: {1}", ((a + c - e) * 9898 + 1000), ((a + c - e) * 9898 + 1000).GetType());
            Console.WriteLine("Resultat d == d: {0} \nAusdruckstyp: {1}", (d == d), (d == d).GetType());
            Console.WriteLine("Resultat c ?? 1000: {0} \nAusdruckstyp: {1}", (c ?? 1000), (c ?? 1000).GetType());
            Console.WriteLine("Resultat e ?? 1000: {0} \nAusdruckstyp: {1}", (e ?? 1000), (e ?? 1000).GetType());
            
            
            
            Console.ReadKey();
        }
    }
}

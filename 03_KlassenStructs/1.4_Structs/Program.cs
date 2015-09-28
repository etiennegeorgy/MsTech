using System;

namespace _1._4_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexStruct struct1 = new ComplexStruct(10, 20);
            Console.WriteLine("Complex struct1: {0}", struct1);

            ComplexClass class1 = new ComplexClass(10, 20);
            Console.WriteLine("Complex class1: {0}", class1);

            // TODO: Führen Sie AddReal (unten) für struct1 / class1 aus mit real = 5 aus

            // TODO: Überlegen Sie sich, wie struct1 / class1 nun aussehen
            // TODO: Geben Sie struct1 / class1 aus

            Console.WriteLine("-------------------------------------------");

            ComplexStruct struct2 = new ComplexStruct(10, 20);
            Console.WriteLine("Complex struct2: {0}", struct2);

            ComplexClass class2 = new ComplexClass(10, 20);
            Console.WriteLine("Complex class2: {0}", class2);

            // TODO: Ändern Sie den AddReal (unten) so, dass struct2 / class2 nach dem Aufruf mit real = 5 identische Werte enthalten
            //       (evtl. Kopien anlegen damit Code weiter oben noch funktioniert)

            // TODO: Führen Sie AddReal (unten) für struct2 / class2 aus mit real = 5 aus

            // TODO: Geben Sie struct2 / class2 aus

            Console.ReadKey();
        }

        private static void AddReal(ComplexStruct complex, int real)
        {
            complex.Real += real;
        }
        private static void AddReal(ComplexClass complex, int real)
        {
            complex.Real += real;
        }
    }
}

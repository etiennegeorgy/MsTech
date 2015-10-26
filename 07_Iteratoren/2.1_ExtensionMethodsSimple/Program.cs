using System;

namespace _2._1_ExtensionMethodsSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- \r\nCamelCase");
            TestCamelCase();
         

            Console.ReadKey();
        }

        private static void TestCamelCase()
        {
            string[] identifiers = new string[] {
              "do_something",
              "find_all_objects",
               "get_last_dict_entry"
             };

            // TODO: Bringe folgenden Code zum laufen
            //foreach (string s in identifiers)
            //    Console.WriteLine("{0} becomes: {1}", s, Extensions.CamelCase(s));
            //foreach (string s in identifiers)
            //    Console.WriteLine("{0} becomes: {1}", s, s.CamelCase());
        }


    }
}

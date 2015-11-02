using System;
using System.Collections.Generic;

namespace _1._1_ExtensionMethods_QueryOperators
{
    class Program
    {
        private static string[] Cities
        {
            get
            {
                return new[] { "Bern", "Basel", "Zürich", "Rapperswil", "Genf" };
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------- \r\nHsrForEach");
            TestForEach();
            Console.WriteLine("---------- \r\nHsrWhere");
            TestWhere();
            Console.WriteLine("---------- \r\nHsrOfType");
            TestOfType();
            Console.WriteLine("---------- \r\nHsrToList");
            TestToList();
            Console.WriteLine("---------- \r\nHsrSum");
            TestSum();

            Console.ReadKey();
        }

        public static void TestForEach()
        {
            // TODO: Bringe folgenden Code zum laufen            
            Console.WriteLine("HsrForEach / Cities");
            Cities.HsrForEach(s => Console.WriteLine(s));
            Console.WriteLine("HsrForEach / Cities (Upper-Case)");
            Cities.HsrForEach(s => Console.WriteLine(s.ToUpper()));
        }
        public static void TestWhere()
        {
            // TODO: Bringe folgenden Code zum laufen
            IEnumerable<string> q1 = Extensions.HsrWhere(Cities, s => s.Length < 5);
            IEnumerable<string> q2 = Cities.HsrWhere(s => s.Length < 5);

			q1.HsrForEach(Console.WriteLine);
            q2.HsrForEach(s => Console.WriteLine(s));

            Cities.HsrWhere(s => s.Length < 5).HsrForEach(s => Console.WriteLine(s));
        }
        public static void TestOfType()
        {
            object[] objs = { 1, "Rapperswil", true, "Zürich", 7.9, "Bern" };

            // TODO: Bringe folgenden Code zum laufen
            IEnumerable<string> q1 = objs.HsrOfType<string>();
            q1.HsrForEach(s => Console.WriteLine(s));

        }
        public static void TestToList()
        {
            // TODO: Bringe folgenden Code zum laufen
            List<string> res = Cities.HsrToList();
			res.HsrForEach(Console.WriteLine);
        }
        public static void TestSum()
        {
            // TODO: Bringe folgenden Code zum laufen
            int totalLength = Cities.HsrSum(c => c.Length);
			Console.WriteLine("TotalLength = {0}", totalLength);
        }
    }
}

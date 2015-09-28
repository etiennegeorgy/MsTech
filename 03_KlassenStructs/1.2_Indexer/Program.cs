using System;

namespace _1._2_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList bookList = new BookList();

            // TODO: Ausgabe eines Buches über Index-Zugriff (int)
            Console.WriteLine(bookList[0]);
            // TODO: Ausgabe eines Buches über Index-Zugriff (string)
            Console.WriteLine(bookList["The Green Mile"]);

            Console.ReadKey();
        }
    }
}

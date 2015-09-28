using System;

namespace _1._1_Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("The Green Mile", "Stephen King", false);
            Book b2 = new Book("It", "Stephen King");
            Book b3 = new Book("Misery");
            Book b4 = new Book();

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);

            Console.ReadKey();
        }
    }
}

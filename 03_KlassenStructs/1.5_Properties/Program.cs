using System;

namespace _1._5_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test mit einem Autoren
            
            // TODO: uncleBob-Variable verwenden
            //var uncleBob = new Author("Robert C.", "Martin");

            Header("Uncle Bob");

            // TODO: Geben Sie den Namen des Autors (uncleBob) mit den Properties für Vor- und Nachnamen aus.

            // TODO: Geben Sie den vollen Namen des Autors mit einem Property aus.

            // TODO: Geben sie den Wert des "Ist anonym"-Property aus.
            // Der Autor sollte hier nicht anonym sein.

            // TODO: Ändern Sie den Wert des "Ist anonym"-Properties, dass der Autor nun als anonym behandelt wird.

            // TODO: Geben Sie erneut den Wert des "Ist anonym"-Properties aus.
            // Der Autor sollte nun als anonym gelten. 

            // TODO: Geben Sie den vollen Namen des Autors aus.
            // Er sollte nun "anonymous" heissen.

            Console.WriteLine();


            // Test mit einem anonymen Autoren
            var anonymousAuthor = new Author();

            Header("Anonymous Author");

            // TODO: Geben Sie den vollen Namen des anonymen Autors (anonymousAuthor) mit einem Property aus.

            // TODO: Geben Sie den Wert des "Ist anonym"-Properties aus.
            // Der Autor sollte anonym sein.

            // TODO: Ändern Sie den Status des "Ist anonym"-Properties, sodass der Autor nicht mehr anonym wäre.

            // TODO: Geben Sie erneut den Wert des "Ist anonym"-Properties aus.
            // Der Autor sollte nun immernoch anonym sein. 

            Console.ReadKey();
        }

        private static void Header(string author)
        {
            var header = string.Format("Testing: {0}", author);
            Console.WriteLine(header);
            Console.WriteLine(new string('#', header.Length));
        }
    }
}

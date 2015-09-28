using System;

namespace _1._4_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definieren Sie folgenden String (Inhalt muss absolut identisch sein / gültiger Pfad!)
            // string path = ... / Inhalt: C:\Temp\Hello.txt
            string path = @"C:\Temp\Hello.txt";

            // Geben Sie path auf die Konsole aus
            System.Console.WriteLine(path);

            // Geben Sie path in UPPERCASE auf die Konsole aus
            System.Console.WriteLine(path.ToUpper());

            // Ersetzen Sie \ durch / und geben Sie das Resultat auf die Konsole aus
            System.Console.WriteLine(path.Replace(@"\", @"/"));

            // Zerlegen Sie den String in ein Array (Separator = \) und geben Sie die Elemente auf die Konsole aus
            string[] array = path.Split('\\');
            foreach (string str in array)
            {
                System.Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}

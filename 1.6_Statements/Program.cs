using System;

namespace _1._6_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // PromptHeight() verwenden, um Höhe des Baumes (ohne Stamm) einzulesen
            int height = PromptHeight();
            
            // Ungültige Eingabe behandeln
            if (height == 0)
            {
                System.Console.WriteLine("Programm wird beendet");
            }

            // Nadelwerk zeichnen
            else
            {
                for (int i = height; i > 0; i--)
                {
                    for (int j = i; j <= height; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }


                // Stamm zeichnen
                int trunkWidth = height / 3;
                int trunkHeight = height / 2;
                for (int i = trunkHeight; i > 0; i--)
                {
                    for (int j = 0; j < trunkWidth; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }

            // TODO: Loop implementieren
           
            Console.ReadKey();
        }

        private static int PromptHeight()
        {
            Console.Write("Maximale Breite eingeben 2 - 20: ");

            string heightInput = Console.ReadLine();

            int height;
            if (int.TryParse(heightInput, out height))
            {
                if (height < 2 || height > 20)
                {
                    Console.WriteLine("Ungültiger Wert eingegeben! Die Zahl muss zwischen 2 und 20 liegen!");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Ungültiger Wert eingegeben! Kann nicht interpretiert werden!");
                return 0;
            }

            return height;
        }

    }
}

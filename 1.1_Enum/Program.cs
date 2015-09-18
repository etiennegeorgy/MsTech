using System;

namespace _1._1_Enum
{
    // TODO: enum "Volume" implementieren
    enum Volume {Unknown, Low, Medium, High}; 

    class Program
    {
       
        static void Main(string[] args)
        {
            // TODO: Volume-Variable erstellen
            Volume vol = Volume.Unknown;

            // TODO: Ausgabe über PrintVolume
            PrintVolume(vol);

            // TODO: volumeString via ParseVolume(...) in Volume-Variable speichern
            string volumeString = "High";
            vol = ParseVolume(volumeString);
            
            // TODO: Ausgabe über PrintVolume
            PrintVolume(vol);
            Console.ReadKey();
        }

        // TODO: public static void PrintVolume... 
        // Ausgabe: The volume is 'Low' / value '2'
        public static void PrintVolume(Volume volume)
        {
            Console.WriteLine("The volume is '{0}' / value '{1}'", volume, (int) volume);
        }
        // TODO: public static Volume ParseVolume...
        public static Volume ParseVolume(string input)
        {
            Volume output = Volume.Unknown;
            switch (input)
            {
                case "Low": 
                    output = Volume.Low;
                    break;
                case "Medium": 
                    output = Volume.Medium;
                    break;
                case "High": 
                    output = Volume.High;
                    break;
                default:
                    break;
            }
            return output;
        }
    }
}

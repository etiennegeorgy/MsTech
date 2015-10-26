using System;

namespace _2._1_ExtensionMethodsSimple
{
    public static class Extensions
    {
        // TODO: CamelCase hier als Extension-Method implementieren (Funktionalität für das Casing ist in "ToCamelCaseInternal" enthalten).

       

        private static string ToCamelCaseInternal(string s)
        {
            string newString = "";
            bool sawUnderscore = false;

            foreach (char c in s)
            {
                if ((newString.Length == 0) && char.IsLetter(c))
                    newString += char.ToUpper(c);
                else if (c == '_')
                    sawUnderscore = true;
                else if (sawUnderscore)
                {
                    newString += char.ToUpper(c);
                    sawUnderscore = false;
                }
                else
                    newString += c;
            }

            return newString;
        }
    }
}

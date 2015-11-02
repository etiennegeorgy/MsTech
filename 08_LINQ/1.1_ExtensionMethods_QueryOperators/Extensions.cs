using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._1_ExtensionMethods_QueryOperators
{
    /// <summary>
    /// Dokumentation der offiziellen LINQ Extension Methods:
    /// http://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods.aspx
    /// 
    /// Nutzen Sie diese Dokumentation um Ihre Extension Methods zu implementieren.
    /// Sie finden dort auch die Beschreibung, was die Methode effektiv für einen Effekt hat.
    /// </summary>
    public static class Extensions
    {
        // TODO: HsrForEach
        public static void HsrForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T e in source)
            {
                action(e);
            }
        }

        // TODO: HsrWhere
        public static IEnumerable<T> HsrWhere<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        } 

        // TODO: HsrOfType
        public static IEnumerable<T> HsrOfType<T>(this IEnumerable source)
        {
            foreach (object item in source)
            {
                if (item is T)
                {
                    yield return (T) item;
                }
            }
        }

        // TODO: HsrToList
        public static List<T> HsrToList<T>(this IEnumerable<T> source)
        {
            List<T> output = new List<T>();
            foreach (T item in source)
            {
                output.Add(item);
            }
            return output;
        }

        // TODO: HsrSum
        public static int HsrSum<T>(this IEnumerable<T> source, Func<T, int> selector)
        {
            int output = 0;
            foreach (T item in source)
            {
                output += selector(item);
            }
            return output;

        }
    }
}

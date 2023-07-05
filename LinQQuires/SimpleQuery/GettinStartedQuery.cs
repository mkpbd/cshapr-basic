using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinQQuires.SimpleQuery
{
    public class GettinStartedQuery
    {
        static string[] names = { "Tom", "Dick", "Harry" };
        public static void GetLengthOfNamedQuery()
        {
            IEnumerable<string> query = names.Where(n => n.Length >= 4);
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
        }

        public static void FluentQuerySyntax()
        {
            IEnumerable<string> filteredNames = from n in names
                                                where n.Contains("a")
                                                select n;
        }

        public static void LinqQueryMethod()
        {
            IEnumerable<string> query = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());
            foreach (string name in query) Console.WriteLine(name);
        }

        public void LinqQueryChaining()
        {
            // You must import the System.Linq namespace for this to compile:
            IEnumerable<string> filtered = names.Where(n => n.Contains("a"));
            IEnumerable<string> sorted = filtered.OrderBy(n => n.Length);
            IEnumerable<string> finalQuery = sorted.Select(n => n.ToUpper());

            foreach (string name in filtered)
                Console.Write(name + "|"); // Harry|Mary|Jay|

            Console.WriteLine();

            foreach (string name in sorted)
                Console.Write(name + "|"); // Jay|Mary|Harry|

            Console.WriteLine();

            foreach (string name in finalQuery)
                Console.Write(name + "|"); // JAY|MARY|HARR
        }

        public static void ExtensionMethodAreImportant()
        {
            IEnumerable<string> filtered = Enumerable.Where(names, n => n.Contains("a"));
            IEnumerable<string> sorted = Enumerable.OrderBy(filtered, n => n.Length);
            IEnumerable<string> finalQuery = Enumerable.Select(sorted, n => n.ToUpper());

            // same as  query chaining 
            IEnumerable<string> query = names.Where(n => n.Contains("a"))
                        .OrderBy(n => n.Length)
                        .Select(n => n.ToUpper());

        }
    }
}
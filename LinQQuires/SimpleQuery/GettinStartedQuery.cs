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

        public static void QueryExpessionSyntax()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query =
                    from n in names
                    where n.Contains("a") // Filter elements
                    orderby n.Length // Sort elements
                    select n.ToUpper(); // Translate each element  (project)

            foreach (string name in query) Console.WriteLine(name);
        }

        public static void QueryExpessionWithRangVariables()
        {
            var rr = from n in names // n is our range variable
                     where n.Contains("a") // n = directly from the array
                     orderby n.Length // n = subsequent to being filtered
                     select n.ToUpper();// n = subsequent to being sorted
            /// same  as use query syntax or fluent syntax
            var fluentSyntax = names.Where(n => n.Contains("a")) // Locally scoped n
                                 .OrderBy(n => n.Length) // Locally scoped n
                                .Select(n => n.ToUpper()); // Locally scoped n

        }
        public static void DefferedExceptionQuery()
        {
            var numbers = new List<int>() { 1, 2 };
            IEnumerable<int> query = numbers.Select(n => n * 10);
            foreach (int n in query) Console.Write(n + "|"); // 10|20|
            numbers.Clear();
            foreach (int n in query) Console.Write(n + "|"); // <nothing
        }

        public static void DefferedExecutionQueryToList()
        {
            var numbers = new List<int>() { 1, 2 };
            List<int> timesTen = numbers
            .Select(n => n * 10)
            .ToList(); // Executes immediately into a List<int>
            numbers.Clear();
            Console.WriteLine(timesTen.Count); // Still
        }

        public static void CapturedVariables()
        {
            int[] numbers = { 1, 2 };
            int factor = 10;
            IEnumerable<int> query = numbers.Select(n => n * factor);
            factor = 20;
            foreach (int n in query) Console.Write(n + "|"); // 20|40|
        }
        public static void ReomveAllVowelsUsingCaptureVariables()
        {
            IEnumerable<char> query = "Not what you might expect";
            query = query.Where(c => c != 'a');
            query = query.Where(c => c != 'e');
            query = query.Where(c => c != 'i');
            query = query.Where(c => c != 'o');
            query = query.Where(c => c != 'u');
            foreach (char c in query) Console.Write(c); // Nt wht y mght xpct
        }
    }
}
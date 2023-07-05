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
    }
}
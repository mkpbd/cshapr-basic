using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinQQuires.SimpleQuery
{
    public class SubQuery
    {
        public static void SubQuerySimpleExamples()
        {
            string[] musos = { "David Gilmour", "Roger Waters", "Rick Wright", "Nick Mason" };
            IEnumerable<string> query = musos.OrderBy(m => m.Split().Last());
        }

        public static void SubQueryIsPrivateScope()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> outerQuery = names
            .Where(n => n.Length == names.OrderBy(n2 => n2.Length)
            .Select(n2 =>
            n2.Length).First());

            // Here's the same thing as a Query Expression
            IEnumerable<string> outerQueryExpression =
                    from n in names
                    where n.Length ==
                    (from n2 in names
                     orderby n2.Length
                     select
                     n2.Length).First()
                    select n;
        }

        public static void SubQueryAggregationWithMinimum()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query =
                        from n in names
                        where n.Length == names.OrderBy(n2 => n2.Length).First().Length
                        select n;
            // With the Min aggregation function, we can simplify the query further:
            IEnumerable<string> queryExpression =
                                    from n in names
                                    where n.Length == names.Min(n2 => n2.Length)
                                    select n;
        }

        public static void SubQueryWithOuterVariablesQueryExpression()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            int shortest = names.Min(n => n.Length);
            IEnumerable<string> query = from n in names
                                        where n.Length == shortest
                                        select n;
        }

        public static void ProgressiveQueryBuilding()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            var filtered = names.Where(n => n.Contains("a"));
            var sorted = filtered.OrderBy(n => n);
            var query = sorted.Select(n => n.ToUpper());
        }

        public static void RemoveVowelsUsingProgressiveQuery()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query = names
                        .Select(n => n.Replace("a", "").Replace("e", "").Replace("i", "")
                        .Replace("o", "").Replace("u", ""))
                        .Where(n => n.Length > 2)
                        .OrderBy(n => n);
            // Dck
            // Hrry
            // Mry

            // here's Same as 
            IEnumerable<string> query2 =
                            from n in names
                            where n.Length > 2
                            orderby n
                            select n.Replace("a", "").Replace("e", "").Replace("i", "")
                            .Replace("o", "").Replace("u", "");
            // Fortunately, there are a number of ways to get the original result in query syntax. 
            // The first is by querying progressively:

            IEnumerable<string> query3 =
                            from n in names
                            select n.Replace("a", "").Replace("e", "").Replace("i", "")
                            .Replace("o", "").Replace("u", "");
            query3 = from n in query3 where n.Length > 2 orderby n select n;

        }

        public static void ProgressiveQueryWithIntoKeyword()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query =
                        from n in names
                        select n.Replace("a", "").Replace("e", "").Replace("i", "")
                        .Replace("o", "").Replace("u", "")
                        into noVowel
                        where noVowel.Length > 2
                        orderby noVowel
                        select noVowel;
        }
        public static void WrappingSementicallyProgressiveQueryBuildings()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query =
                        from n in names
                        select n.Replace("a", "").Replace("e", "").Replace("i", "")
                        .Replace("o", "").Replace("u", "");
            query = from n in query where n.Length > 2 orderby n select n;

            // Same As Reformulated in wrapped form, it’s the following
            IEnumerable<string> query2 =
                        from n1 in
                        (
                        from n2 in names
                        select n2.Replace("a", "").Replace("e", "").Replace("i", "")
                        .Replace("o", "").Replace("u", "")
                        )
                        where n1.Length > 2
                        orderby n1
                        select n1;

            // When converted to fluent syntax, the result is the same linear chain of
            // operators as in previous examples

            IEnumerable<string> query3 = names
            .Select(n => n.Replace("a", "").Replace("e", "").Replace("i", "")
            .Replace("o", "").Replace("u", ""))
            .Where(n => n.Length > 2)
            .OrderBy(n => n);

        }
    }
}
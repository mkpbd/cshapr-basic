using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinQQuires.SimpleQuery
{
    public class LetKeywordForQuery
    {
        static string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        public static void LetKeyword()
        {
            IEnumerable<string> query =
                from n in names
                let vowelless = n.Replace("a", "").Replace("e", "").Replace
                ("i", "")
                .Replace("o", "").Replace("u", "")
                where vowelless.Length > 2
                orderby vowelless
                select n; // Thanks to let, n is still in scope.
        }

    }
}
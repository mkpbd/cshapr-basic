using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinQQuires.SimpleQuery
{
    public class ProjectionStrategis
    {
        static string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        public static void ObjectInitialization()
        {

            IEnumerable<TempProjectionItem> temp =
            from n in names
            select new TempProjectionItem
            {
                Original = n,
                Vowelless = n.Replace("a", "").Replace("e", "").Replace
            ("i", "")
            .Replace("o", "").Replace("u", "")
            };
        }

        public static void AnonymousTypeObjectInitialized()
        {
            var intermediate = from n in names
                               select new
                               {
                                   Original = n,
                                   Vowelless = n.Replace("a", "").Replace("e", "").Replace
                               ("i", "")
                               .Replace("o", "").Replace("u", "")
                               };
            IEnumerable<string> query = from item in intermediate
                                        where item.Vowelless.Length > 2
                                        select item.Original;


            var query3 = from n in names
                         select new
                         {
                             Original = n,
                             Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "")
                         .Replace("o", "").Replace("u", "")
                         }
                        into temp
                         where temp.Vowelless.Length > 2
                         select temp.Original;
        }


    }
}
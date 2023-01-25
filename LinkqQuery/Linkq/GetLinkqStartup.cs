using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkqQuery.Linkq
{
    public class GetLinkqStartup
    {
        public string[] names = { "Tom", "Dick", "Harry" };

        public void GetLinkqStartupQyery() {
            IEnumerable<string> firstName = System.Linq.Enumerable.Where(names, (x => x.Length >= 3));

            foreach (string name in firstName)
            {
                Console.WriteLine($"Name : {name}");
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
    public class MyCollection : IEnumerable
    {
        int[] data = { 1, 2, 3 };
        public IEnumerator GetEnumerator()
        {
            foreach (int i in data)
                yield return i;
        }
    }
}

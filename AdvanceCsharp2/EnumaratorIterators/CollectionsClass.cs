using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharp2.EnumaratorIterators
{
    public class CollectionsClass
    {

        public void GetEnumatorsIterators()
        {
            using (var enumators = "Hello Kamal".GetEnumerator())
            {
                while(enumators.MoveNext())
                {
                    Console.WriteLine(enumators.Current);
                }
            }
        }


        public void CollectionList()
        {
            List<int> lis = new List<int>();
            lis.Add(5);
            lis.Add(20);
            lis.Add(30);
            lis.Add(40);

            foreach (int i in lis) Console.Write(i + " ,");
        }


        public void CollectionOfDictonary()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>
            {
                {1,"kamal" },
                {2, "jamal" },
                {3, "Tomal" },
                {4,"damal" }
            };


            foreach(var d in dic)
            {
                Console.WriteLine(d.Key + " "+ d.Value);
            }
        }


        public void CollectionOfIterator()
        {
            foreach(var r in Fibs(10))
            {
                Console.WriteLine(r);
            }
        }

        public  IEnumerable<int> Fibs(int fibCount){

            for(int i = 0, prev = 1, curr = 1; i<fibCount; i++)
            {
                yield return prev;
                int newFib = prev + curr;

                prev = curr;
                curr = newFib;
            }

            
        }

        IEnumerable<string> Foo()
        {
            yield return "One";
            yield return "Two";
            yield return "Three";
        }

        IEnumerable<string> Foo(bool breakEarly)
        {
            yield return "One";
            yield return "Two";
            if (breakEarly)
                yield break;
            yield return "Three";
        }

    }
}

using Collection.Classes;
using System.Collections;
using Collection.Interfaces;
string s = "Hello";
// Because string implements IEnumerableOwn, we can call GetEnumerator():
IEnumerator rator = s.GetEnumerator();

while (rator.MoveNext())
{
    char c = (char)rator.Current;
    Console.Write(c + ".");
}

foreach (int i in MyGenCollection.GetSomeIntegers())
    Console.WriteLine(i);

var wishList = new List<Wish>();
wishList.Add(new Wish("Peace", 2));
wishList.Add(new Wish("Wealth", 3));
wishList.Add(new Wish("Love", 2));
wishList.Add(new Wish("3 more wishes", 1));
wishList.Sort(new PriorityComparer());
foreach (Wish w in wishList) Console.Write(w.Name + " | ");
// OUTPUT: 3 more wishes | Love | Peace | Wealth |

var dic = new SortedDictionary<string, string>(new SurnameComparer());
dic.Add("MacPhail", "second!");
dic.Add("MacWilliam", "third!");
dic.Add("McDonald", "first!");
foreach (string ss in dic.Values)
    Console.Write(ss + " "); // first! second! third!
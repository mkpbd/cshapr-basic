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
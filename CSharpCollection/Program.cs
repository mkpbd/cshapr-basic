// See https://aka.ms/new-console-template for more information
using CSharpCollection;
using System.Collections;

string s = "Hello";
// Because string implements IEnumerable, we can call GetEnumerator():
IEnumerator rator = s.GetEnumerator();
while (rator.MoveNext())
{
    char c = (char)rator.Current;
    Console.Write(c + ".");
}

foreach (char c in s)
    Console.Write(c + ".");
﻿// See https://aka.ms/new-console-template for more information
using CSharpCollection;
using System.Collections;
using System.ComponentModel;
using System.Xml.Linq;

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


int[] data = { 1, 2, 3 };
var ratora = ((System.Collections.Generic.IEnumerable<int>)data).GetEnumerator();


string[] names = { "Rodney", "Jack", "Jill" };
//string match = Array.Find(names, ContainsA);
//Console.WriteLine(match); // Jack
//ContainsA(string name) { return name.Contains("a"); }
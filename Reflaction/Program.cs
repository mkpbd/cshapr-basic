

using Reflaction.ClassAndPropertices;
using System.Reflection;

Type t = typeof(string);

Type d = typeof(DateTime);

Type g = typeof(Dictionary<int, int>);

Type  asm = Assembly.GetExecutingAssembly().GetType("Reflaction");

//Console.WriteLine($"Full Name : {t.FullName}");
//Console.WriteLine($"Name : {t.Name}");
//Console.WriteLine($"Name Sapce  : {t.Namespace}");
//Console.WriteLine($"Base Type  : {t.BaseType}");
//Console.WriteLine($"Date Type  : {d.FullName}");

//Console.WriteLine(g.FullName);
//Console.WriteLine(asm.FullName);

User user = new User();
//user.AssambolyClass();
user.LoadAssamboly();


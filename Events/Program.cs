using Events.Lamda;
using Events.Evn;
using Events.Extension;



var source = new Eventful();
source.Announcement += m => Console.WriteLine("Announcement: " + m);



Func<string> greetor = () => "Hello, world";
Func<int, int> sqr = x => x * x;
Func<int> natural = LamdaExpression.Natural();
Console.WriteLine(natural()); // 0
Console.WriteLine(natural()); // 1

Action[] actions = new Action[3];
for (int i = 0; i < 3; i++)
    actions[i] = () => Console.Write(i);
foreach (Action a in actions) a(); // 33


Console.WriteLine("Perth".IsCapitalized());

// Console.WriteLine(String.IsCapitalized("Perth"));

var dude = new { Name = "Bob", Age = 23 };
int Age = 23;
var dude1 = new { Name = "Bob", Age, Age.ToString().Length };

var a1 = new { X = 2, Y = 4 };
var a2 = new { X = 2, Y = 4 };
Console.WriteLine(a1.GetType() == a2.GetType()); // True
Console.WriteLine(a1.Equals(a2)); // True
Console.WriteLine(a1 == a2); // False

var bob = ("Bob", 23); // Allow compiler to infer the element types
Console.WriteLine(bob.Item1); // Bob
Console.WriteLine(bob.Item2); // 23

(string, int) bob1 = ("Bob", 23);

var tuple = (name: "Bob", age: 23);

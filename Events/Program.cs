using Events.Lamda;
using Events.Evn;



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
using AdvanceApp.Delegates;

Transform transform = new Transform();

Transformer tns = transform.Square;

Console.WriteLine(tns(10));

Transformer trans = new Transformer(transform.Square);
trans.Invoke(3);
var r = trans(30);
System.Console.WriteLine(r);
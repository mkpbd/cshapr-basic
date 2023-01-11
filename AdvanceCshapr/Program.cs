

using AdvanceCshapr.Classes;
using AdvanceCshapr.Delegates;

CalculationDelegateClass delC = new CalculationDelegateClass();

Transformer trans = delC.sum;
//Transformers trans = delC.sum;
Transformer tran = delC.Multiply;
//Console.WriteLine(trans.Invoke(6));
//Console.WriteLine(tran.Invoke(5));
var values = new int[] { 3, 4, 5, 6, 7, 8 };

//delC.Transform(values, trans);
//delC.Transform(values, tran);


//foreach (var v in values) Console.WriteLine(v);


Transformer del = delC.sum;
del += delC.Multiply;
Util util = new Util();
Console.WriteLine(del.Invoke(5));
ProgressReporters p = util.WriteProgressToConsole;
p += util.WriteProgressToFile;
//Util.HardWork(p);

//util.Transformer(values, delC.sum);

//foreach(var v in values) Console.Write(v + " , ");

Util.TransformAll(values, new Squarer());
//foreach (var v in values) Console.Write(v + " , ");


Action[] actions = new Action[3];

//for (int i = 0; i < 3; i++)
//    actions[i] = () => Console.Write(i);
//foreach (Action a in actions) a(); // 333


// Notice that we omit the parameters:
new Foo().Clicked += delegate { Console.WriteLine("clicked"); };
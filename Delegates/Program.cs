using Delegates.Del;

Transformer t = Test.Square; // Create delegate instance
int result = t(3); // Invoke delegate
Console.WriteLine(result); // 9




int[] values = { 1, 2, 3 };
new Utility().Transform(values, new Utility().Square); // Hook in the Square method
foreach (int i in values)
    Console.Write(i + " "); // 1 4 9

MyReporter r = new MyReporter();
r.Prefix = "%Complete: ";
ProgressReporter p = r.ReportProgress;
p(99); // %Complete: 99
Console.WriteLine(p.Target == r); // True
Console.WriteLine(p.Method); // Void ReportProgress(Int32)
r.Prefix = "";
p(99);

StringAction sa = new StringAction(new Utility().ActOnObject);
sa("hello string");


ProgressReporter pp = new Utility().WriteProgressToConsole;
pp += new Utility().WriteProgressToFile;
Utility.HardWork(pp);

ObjectRetriever o = new ObjectRetriever(new Utility().RetriveString);
object results = o();
Console.WriteLine(results); // hello

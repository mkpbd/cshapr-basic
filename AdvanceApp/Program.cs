using AdvanceApp.Delegates;

Transform transform = new Transform();

Transformer tns = transform.Square;

// Console.WriteLine(tns(10));

Transformer trans = new Transformer(transform.Square);
trans.Invoke(3);
var rr = trans(30);
// System.Console.WriteLine(rr);

int[] values = new int[] { 2, 3, 4, 5 };

transform.TransformDelegate(values, transform.Square);// Hook in the Square method
// foreach (int i in values) Console.Write(i + " ");

Transformer tCube = Test.Cube;
Console.WriteLine("");
// Console.WriteLine(tCube.Invoke(33));

MyReporter r = new MyReporter();
r.Prefix = "%Complete: ";
ProgressReporter p = r.ReportProgress;
p(99); // %Complete: 99
Console.WriteLine(p.Target == r); // True
Console.WriteLine(p.Method); // Void ReportProgress(Int32)
r.Prefix = "";
p(99); // 99

//================= multicast delegate ===================
ProgressReporterMultiCast pp = WriteProgressToConsole;
p += WriteProgressToFile;
Util.HardWork(pp);
void WriteProgressToConsole(int percentComplete)
=> Console.WriteLine(percentComplete);
void WriteProgressToFile(int percentComplete)
=> System.IO.File.WriteAllText("progress.txt",
percentComplete.ToString());


var zeroThreshold = new ThresholdComparer { Threshold = 0 };
var tenThreshold = new ThresholdComparer { Threshold = 10 };
var hundredThreshold = new ThresholdComparer { Threshold = 100 };
Predicates<int> greaterThanZero = zeroThreshold.IsGreaterThan;
Predicates<int> greaterThanTen = tenThreshold.IsGreaterThan;
Predicates<int> greaterThanOneHundred = hundredThreshold.IsGreaterThan;

ThresholdComparer.CallMeRightBack(greaterThanZero);

Predicate<object> po = ThresholdComparer.IsLongString;
Predicate<string> ps = po;
Console.WriteLine(ps("Too short"));
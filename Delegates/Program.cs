using Delegates.Del;

Transformer t = Test.Square; // Create delegate instance
int result = t(3); // Invoke delegate
Console.WriteLine(result); // 9




int[] values = { 1, 2, 3 };
new Utility().Transform(values, new Utility().Square); // Hook in the Square method
foreach (int i in values)
    Console.Write(i + " "); // 1 4 9
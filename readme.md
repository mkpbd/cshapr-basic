Dotnet app install

dotnet new console -n  Delegate

Run the App

dotnet run Delegate

**Delegates**
A delegate is an object that knows how to call a method.
A delegate type defines the kind of method that delegate instances can call. Specifically, it defines the method’s return type and its parameter types. The following defines a delegate type called Transformer:

```csharp
delegate int Transformer (int x);
```

**Transformer** is compatible with any method with an **int return type** and a single int parameter, such as

this:

```csharp
int Square (int x) { return x * x; }
```

Assigning a method to a delegate variable creates a delegate instance

```csharp
Transformer t = Test.Square;


namespace Delegates.Del
{
    public class Test
    {
        public static int Square(int x) => x * x;
    }
}
```

is shorthand for

```csharp
Transformer t = new Transformer (Test.Square);
```

Technically, we are specifying a method group when we refer to Square without brackets or arguments.

If the method is overloaded, C# will pick the correct overload based on the signature of the delegate to which it’s being assigned.

The expression

```csharp
t(3);

// or Shorthand for
t.Invoke(3)
```

A delegate is similar to a callback, a general term that captures constructs such as C function pointers.

**Methods with Delegate**s

A delegate variable is assigned a method at runtime. This is useful for writing plug-in methods.

```csharp
int[] values = { 1, 2, 3 };
Transform (values, Square); // Hook in the Square method
foreach (int i in values)
Console.Write (i + " "); // 1 4 9
void Transform (int[] values, Transformer t)
{
for (int i = 0; i < values.Length; i++)
values[i] = t (values[i]);
}
int Square (int x) => x * x;
int Cube (int x) => x * x * x;
delegate int Transformer (int x);
```

We can change the transformation just by changing Square to Cube in the second line of code.
Our Transform method is a higher-order function because it’s a function that takes a function as an argument. (A method that returns a delegate would also be a higher-order function.)

**Multicast Delegates**

All delegate instances have multicast capability. This means that a delegate instance can reference not **just a single target method, but also a list of target methods. The + and += operators combine delegate instances**

***Delegates are immutable, so when you call += or -=, you’re in fact creating a new delegate instance and assigning it to the existing variable.***

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates.Del
{
    public class Utility
    {
        public void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
        public int Square(int x) => x * x;
        public int Cube(int x) => x * x * x;

        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10); // Invoke delegate
                System.Threading.Thread.Sleep(100); // Simulate hard work
            }
        }
        public void WriteProgressToConsole(int percentComplete) => Console.WriteLine(percentComplete);
        public void WriteProgressToFile(int percentComplete) => System.IO.File.WriteAllText("progress.txt",
            percentComplete.ToString());
    }
}

namespace Delegates.Del
{
    public delegate int Transformer(int x);// create a new transformer delegate
    public delegate void ProgressReporter(int percentComplete); // progress reporter delegate
}

//Program.cs
ProgressReporter pp = new Utility().WriteProgressToConsole;
pp += new Utility().WriteProgressToFile;
Utility.HardWork(pp);

```

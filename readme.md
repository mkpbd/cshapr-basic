Install dotnet Console Application project

    dotnet new console -n AdvanceProject

run  advance application

    **dotnet run AdvanceProject**

or

   **dotnet build AdvanceProject.csproj**

## delegates

A delegate is an object that knows how to call a method. A delegate type defines the kind of method that delegate instances can call. Specifically, it defines the method's return type and its parameter types

```csharp
delegate int Transformer (int x);
int Square (int x) { return x * x; }
Transformer t = Square; // Create delegate instance
int result = t(3); // Invoke delegate
Console.WriteLine (result); // 9
```

A delegate instance literally acts as a delegate for the caller: the caller invokes the delegate and then the delegate calls the target method. This indirection decouples the caller from the target method.

```csharp
Transformer t = new Transformer (Square);
Transformer t = Square; // Create delegate instance
int result = t(3); // Invoke delegate
Console.WriteLine (result); // 9
int Square (int x) => x * x;
delegate int Transformer (int x); // Delegate type declaration
```

A delegate instance literally acts as a delegate for the caller: the caller invokes the delegate and then the delegate calls the target method. This indirection decouples the caller from the target method.

A delegate is similar to a callback, a general term that captures constructs such as C function pointers.

**Writing Plug-in Methods with Delegates**

A delegate variable is assigned a method at runtime. This is useful for writing plug-in methods. In this example, we have a utility method named Transform that applies a transform to each element in an integer array. The Transform method has a delegate parameter, which you can use for specifying a plug-in transform

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

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Delegates
{
    public delegate void ProgressReporter(int percentComplete);
    public class MyReporter
    {
        public string Prefix = "";
        public void ReportProgress(int percentComplete) => Console.WriteLine(Prefix + percentComplete);
    }
}
// Program.cs
MyReporter r = new MyReporter();
r.Prefix = "%Complete: ";
ProgressReporter p = r.ReportProgress;
p(99); // %Complete: 99
Console.WriteLine(p.Target == r); // True
Console.WriteLine(p.Method); // Void ReportProgress(Int32)
r.Prefix = "";
p(99); // 99
```

**Generic Delegate Types**

A delegate type can contain generic type parameters:

```csharp
public delegate T Transformer<T> (T arg);
```

```csharp
int[] values = { 1, 2, 3 };
Util.Transform (values, Square); // Hook in Square
foreach (int i in values)
Console.Write (i + " "); // 1 4 9
int Square (int x) => x * x;
public class Util
{
public static void Transform<T> (T[] values, Transformer<T> t)
{
for (int i = 0; i < values.Length; i++)
values[i] = t (values[i]);
}
}
```

**The Func and Action Delegates**

With generic delegates, it becomes possible to write a small set of delegate types that are so general they can work for methods of any return type and any (reasonable) number of arguments. These delegates are the Func and Action delegates, defined in the System namespace (the in and out annotations indic ate variance, which we cover in the context of delegates shortly):

```csharp
delegate TResult Func <out TResult> ();
delegate TResult Func <in T, out TResult> (T arg);
delegate TResult Func <in T1, in T2, out TResult> (T1 arg1, T2 arg2);
... and so on, up to T16
delegate void Action ();
delegate void Action <in T> (T arg);
delegate void Action <in T1, in T2> (T1 arg1, T2 arg2);
```

These delegates are extremely general. The Transformer delegate in our previous example can be replaced with a Func delegate that takes a single argument of type T and returns a same-typed value:

```csharp
public static void Transform<T> (T[] values, Func<T,T> transformer)
{
for (int i = 0; i < values.Length; i++)
values[i] = transformer (values[i]);
}
```

**Events**

When using delegates, two emergent roles commonly appear: broadcaster and subscriber.
The broadcaster is a type that contains a delegate field. The broadcaster decides when to broadcast, by invoking the delegate

```csharp
// Delegate definition
public delegate void PriceChangedHandler (decimal oldPrice,
decimal newPrice);
public class Broadcaster
{
// Event declaration
public event PriceChangedHandler PriceChanged;
}
```

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Events
{
    public delegate void PriceChangedHandlerDel(decimal oldPrice,
decimal newPrice);
    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) => this.symbol = symbol;

        public event PriceChangedHandlerDel PriceChanged;
        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return; // Exit if nothing has changed
                decimal oldPrice = price;
                price = value;
                if (PriceChanged != null) // If invocation list not
                    PriceChanged(oldPrice, price); // empty, fire event.
            }
        }
    }
}
```

**Standard Event Pattern**

In almost all cases for which events are defined in the .NET libraries, their definition adheres to a standard pattern designed to provide consistency across library and user code. At the core of the standard event pattern is **System.EventArgs**, a predefined .NET class with no members (other than
the static Empty field). EventArgs is a base class for conveying information for an event. In our Stock example, we would subclass EventArgs to convey the old and new prices when a PriceChanged event is fired:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Events
{
    public class PriceChangedEventArgs : System.EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }
}
```

With an **EventArgs** subclass in place, the next step is to choose or define a delegate for the event. There are three rules

It must have a void return type. It must accept two arguments: the first of type object, and the second a
subclass of EventArgs. The first argument indicates the event broadcaster, and the second argument contains the extra information to convey. Its name must end with **EventHandler**

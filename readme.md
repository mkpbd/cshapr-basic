## Events

Create   Constole  project

 dotnet new console -g projectName

run dotnet application

dotnet run project name OR dotnet run build .csproj

When using delegates, two emergent roles commonly appear: broadcaster and subscriber.
The broadcaster is a type that contains a delegate field. The broadcaster decides when to broadcast, by invoking the delegate.

The subscribers are the method target recipients. A subscriber decides when to start and stop listening by calling += and -= on the broadcaster's delegate.  A subscriber does not know about, or interfere with, other subscribers.

The easiest way to declare an event is to put the event keyword in front of a delegate member:

```csharp
// Delegate definition
public delegate void PriceChangedHandler (decimal oldPrice, decimal newPrice);
public class Broadcaster
{
string symbol;
decimal price;
// Event declaration
public event PriceChangedHandler PriceChanged;
public decimal Price
{
  get => price;
  set
   {
     if (price == value) return; // Exit if nothing has changed
     decimal oldPrice = price;
     price = value;
     if (PriceChanged != null) // If invocation list not
      PriceChanged (oldPrice, price); // empty, fire event.
     }
   }
}
```

Code within the Broadcaster type has full access to PriceChanged and can treat it as a delegate. Code outside of Broadcaster can perform only += and -= operations on the PriceChanged event.

Replace other subscribers by reassigning PriceChanged (instead of using the += operator).

Clear all subscribers (by setting **PriceChanged** to **null**).

Broadcast to other subscribers by invoking the delegate.

## **Lambda Expressions**

A lambda expression is an unnamed method written in place of a delegate instance.

 The compiler immediately converts the lambda expression to either

1. A delegate instance
2. An expression tree, of type Expression `<TDelegate>`, representing the code inside the lambda expression in a traversable object model. This allows the lambda expression to be interpreted later at runtim.
3. In the following example, **x => x * x is** a lambda expression

   ```csharp
   Transformer sqr = x => x * x;
   Console.WriteLine (sqr(3)); // 9
   delegate int Transformer (int i);
   ```

A lambda expression has the following form:

**(parameters) => expression-or-statement-block**

x => x * x;

x => { return x * x; };

Lambda expressions are used most commonly with the **Func and Action delegates,** so you will most often see our earlier expression written as

```csharp
Func<int,int> sqr = x => x * x;

Func<string,string,int> totalLength = (s1, s2) => s1.Length + s2.Length;
int total = totalLength ("hello", "world"); // total is 10;
```

If you do not need to use the parameters, you can discard them with an underscore

```csharp
Func<string,string,int> totalLength = (_,_) => ...
Func<string> greetor = () => "Hello, world
var sqr = int (int x) => x;
```

**Capturing Outer Variables**

A lambda expression can reference any variables that are accessible where the lambda expression is defined. These are called outer variables, and can include local variables, parameters, and fields:

```csharp
int factor = 2;
Func<int, int> multiplier = n => n * factor;
Console.WriteLine (multiplier (3));
```

Outer variables referenced by a lambda expression are called captured variables. A lambda expression that captures variables is called a closure.

*Variables can also be captured by anonymous methods and local methods. The rules for capturedvariables, in these cases, are the same.*

Captured variables are evaluated when the delegate is actually invoked, not when the variables were captured

```csharp
int factor = 2;
Func<int, int> multiplier = n => n * factor;
factor = 10;
Console.WriteLine (multiplier (3)); // 30
```

```csharp
int seed = 0;
Func<int> natural = () => seed++;
Console.WriteLine (natural()); // 0
Console.WriteLine (natural()); // 1
Console.WriteLine (seed); // 2
```

Captured variables have their lifetimes extended to that of the delegate. In the following example, the local variable seed would ordinarily disappear from scope when Natural finished executing.

But because seed has been captured, its lifetime is extended to that of the capturing delegate, natural:

## Anonymous Methods

Anonymous methods are a C# 2.0 feature was mostly subsumed  lambda expressions.

An anonymous method is like a lambda expression, but it lacks the following features:

1. Implicitly typed parameters
2. Expression syntax (an anonymous method must always be a statement block)
3. The ability to compile to an expression tree, by assigning to Expression ````````````<T>```````````

   An anonymous method uses the delegate keyword followed (optionally) by a parameter declaration and then a method body.

   ```csharp
   Transformer sqr = delegate (int x) {return x * x;};
   Console.WriteLine (sqr(3)); // 9
   delegate int Transformer (int i);
   ```

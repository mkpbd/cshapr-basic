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

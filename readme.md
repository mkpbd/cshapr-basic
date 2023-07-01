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

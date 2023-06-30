## Compilation

create new project with dotnet CLI

    **dotnet new console -n Basics**

To build and run your program, run the following command from the Basics folder:

    **dotnet run Basics**

Or, if you just want to build without running.

    **dotnet build Basics.csproj**

**Identifiers and Keywords**

Identifiers are names that programmers choose for their classes, methods, variables, and so on. Here are the identifiers in our example program, in the order in which they appear:
 **System x Console WriteLine**

Reserve Keyword

abstract as base  bool  break byte  case
do     double     else    enum    event    explicit
extern    in     int     interface      internal    is    lock    long     protected
public    readonly    record    ref    return    sbyte   throw    true   try   typeof
uint    ulong   unchecked    catch    char     checked      class    const
continue     decimal     default     delegate     false     finally
fixed     float      for      foreach     goto     if
implicit     namespace     new      null      object     operator
out      override     params     private      sealed     short     sizeof    stackalloc
static       string      struct      switch      this     unsafe     ushort
using     virtual     void       volatile     while

## Type Basics

A type defines the blueprint for a value. In this example, we use two literals of type int with values 12 and 30. We also declare a variable of type int whose name is x:

```csharp
int x = 12 * 30;
Console.WriteLine (x);
const int y = 360;
```

**Predefined Type Examples**
Predefined types are types that are specially supported by the compiler. The **int** type is a predefined type for representing the set of integers that fit into 32 bits of memory, from −2 to 2 −1, and is the default type for numeric literals within this range. You can perform functions such as arithmetic with
instances of the **int** type, as follows

int, float, double, string,  decimal, byte, bit, boolean , char, tinyint, ETC

```csharp
string message = "Hello world";
string upperMessage = message.ToUpper();
Console.WriteLine (upperMessage); // HELLO WORLD
int x = 2022;
message = message + x.ToString();
Console.WriteLine (message); // Hello world2022
```
